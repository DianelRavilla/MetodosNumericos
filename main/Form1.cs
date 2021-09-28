using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace MétodosNumericos
{
    public partial class Form1 : Form
    {
        Calculo ADF = new Calculo();
        double ErrorPL = 1;
        double ErrorVL = 0.01;
        int NumIteracion = 5;
        int CifrasRedondeo = 5;
        int CifrasRedondeoEP = 5;
        int CifrasRedondeoEV = 5;
        int caso = 1;
        //caso 1: Por error porcentual
        //caso 2: Por error Verdadero
        //caso 3: Por Iteracion
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icono;
            this.BackgroundImage = Properties.Resources.Fondo;
            pnlPreferencias.BackgroundImage = Properties.Resources.space_man_artistic_galaxy;
            pnlMetodos.Visible = false;
            pnlPreferencias.Visible = false;
            rtxtAyuda.Visible = false;
            btnCerrarAyuda.Visible = false;
        }
        private void BtnPref_Click(object sender, EventArgs e)
        {          
            pnlPreferencias.Visible = true;
        }
        private void BtnSet_Click(object sender, EventArgs e)
        {
            try
            {
                string opcion = cbxPreferencias.Text;
                switch (opcion)
                {
                    case "Error Porcentual":
                        {
                            try
                            {
                                ErrorPL = Convert.ToDouble(txtError.Text);
                                caso = 1;
                                MessageBox.Show("|| SE HA ASIGNADO UN ERROR PORCENTUAL DEL " + ErrorPL + "% !!");
                            }
                            catch
                            {
                                MessageBox.Show("||ERROR EN EL FORMATO INGRESADO!!");
                            }
                        }
                        break;
                    case "Error Verdadero":
                        {
                            try
                            {
                                ErrorVL = Convert.ToDouble(txtError.Text);
                                caso = 2;
                                MessageBox.Show("|| SE HA ASIGNADO UN ERROR VERDADER DE " + ErrorVL + " !!");
                            }
                            catch
                            {
                                MessageBox.Show("||ERROR EN EL FORMATO INGRESADO!!");
                            }
                        }
                        break;
                    case "Iteración":
                        {
                            try
                            {
                                NumIteracion = Convert.ToInt32(txtError.Text);
                                caso = 3;
                                MessageBox.Show("|| SE HA ASIGNADO UN NUMERO DE ITERACIONES DE " + NumIteracion + " !!");
                            }
                            catch
                            {
                                MessageBox.Show("||LAS ITERACIONES SON NUMEROS ENTEROS!!");
                            }
                        }
                        break;
                }             
            }
            catch
            {
                MessageBox.Show("Indica el porcentaje de error máximo tolerable (por defecto es 1)");
            }
            CifrasRedondeo = Int32.Parse(cbx1.Text);
            CifrasRedondeoEP = Int32.Parse(cbx2.Text);
            CifrasRedondeoEV = Int32.Parse(cbx3.Text);
            pnlPreferencias.Visible = false;
        }
        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
            pnlMetodos.Visible = true;
            btnEvaluar.Visible = false;
        }
        private void BtnFalsaPosicion_Click(object sender, EventArgs e)
        {
            FalsaPosicion();
            pnlMetodos.Visible = false;
            btnEvaluar.Visible = true;
            txtA.Text = "";
            txtB.Text = "";
            txtError.Text = "";
        }
        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            Biseccion();
            pnlMetodos.Visible = false;
            btnEvaluar.Visible = true;
            txtA.Text = "";
            txtB.Text = "";
            txtError.Text = "";
        }
        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            rtxtAyuda.Visible = true;
            btnCerrarAyuda.Visible = true;
            btnCerrarAyuda.BringToFront();
        }
        private void BtnCerrarAyuda_Click(object sender, EventArgs e)
        {
            rtxtAyuda.Visible = false;
            btnCerrarAyuda.Visible = false;
        }

        //METODO FALSAPOSICION_METODO FALSAPOSICION_METODO FALSAPOSICION_METODO FALSAPOSICION_METODO FALSAPOSICION_
        double XRFINAL = 0;
        double ERRORPFINAL = 0;
        double ERRORVFINAL = 0;
        private void FalsaPosicion()
        {
            dgvTabla.Rows.Clear();
            if (txtFuncion.Text == "")
            {
                MessageBox.Show("||FUNCION NO ESTABLECIDA||");
                return;
            }
            else if (txtA.Text == "" && txtB.Text == "")
            {
                MessageBox.Show("||LIMITES NO ESTABLECIDOS||");
                return;
            }
            else
            {
                try
                {
                    string valor = txtFuncion.Text;
                    double xi = Math.Round(Convert.ToDouble(txtA.Text),CifrasRedondeo);
                    double xu = Math.Round(Convert.ToDouble(txtB.Text),CifrasRedondeo);
                    if (ADF.Sintaxis(valor, 'x')) //pasamos la funcion con la variable a evaluar
                    {
                        double xr = ValorXr(xi, xu);
                        int fila = dgvTabla.Rows.Add();    
                        dgvTabla.Rows[fila].Cells[0].Value = "1";
                        dgvTabla.Rows[fila].Cells[1].Value = xi;
                        dgvTabla.Rows[fila].Cells[2].Value = xu;
                        dgvTabla.Rows[fila].Cells[3].Value = xr;
                        dgvTabla.Rows[fila].Cells[4].Value = "N/A";
                        dgvTabla.Rows[fila].Cells[5].Value = "N/A";
                        double error = 0;
                        if (caso == 1)
                            error = 100;
                        if (caso == 2)
                            error = 0.01;
                        if (caso == 3)
                            error = NumIteracion;
                        Evaluacion(xi, xu, xr, valor, error, 2);
                    }
                    else
                    {
                        MessageBox.Show("Error en la Sintaxis");  // aquí mensaje de error en sintaxis
                    }
                }
                catch
                {
                    MessageBox.Show("||ERROR NO IDENTIFICADO||");
                }
            }
            //lstVer.SelectedIndex = lstVer.Items.Count - 1;
            //lstVer.SelectedIndex = -1;
        }
        private double ValorXr(double xi, double xu)
        {
            double valor = xu - ((ADF.EvaluaFx(xu) * (xi - xu)) / (ADF.EvaluaFx(xi) - ADF.EvaluaFx(xu)));
            valor = Math.Round(valor, CifrasRedondeo);
            return valor;
        }
        private void Evaluacion(double xi, double xu, double xr, string valor, double error, int c)
        {           
            try
            {
                if (caso == 1)
                {
                    if (error < ErrorPL)
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(xi) * ADF.EvaluaFx(xr) > 0)
                            {
                                xi = xr;
                            }
                            else
                            {
                                xu = xr;
                            }
                            xr = ValorXr(xi, xu);
                            XRFINAL = xr;
                            error = Error_Porcentual(xr, e);
                            double errorV = Error_Verdadero(xr, e);
                            error = Math.Round(error, CifrasRedondeoEP);
                            errorV = Math.Round(errorV, CifrasRedondeoEV);
                            ERRORPFINAL = error;
                            ERRORVFINAL = errorV;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = xi;
                            dgvTabla.Rows[fila].Cells[2].Value = xu;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = error;
                            dgvTabla.Rows[fila].Cells[5].Value = errorV;
                            c++;
                        }
                        Evaluacion(xi, xu, xr, valor, error, c);
                    }
                }
                if (caso == 2)
                {
                    if (error < ErrorVL)
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(xi) * ADF.EvaluaFx(xr) > 0)
                            {
                                xi = xr;
                            }
                            else
                            {
                                xu = xr;
                            }
                            xr = ValorXr(xi, xu);
                            XRFINAL = xr;
                            double errorP = Error_Porcentual(xr, e);
                            error = Error_Verdadero(xr, e);
                            errorP = Math.Round(errorP, CifrasRedondeoEP);
                            error = Math.Round(error, CifrasRedondeoEV);
                            ERRORVFINAL = error;
                            ERRORPFINAL = errorP;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = xi;
                            dgvTabla.Rows[fila].Cells[2].Value = xu;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = errorP;
                            dgvTabla.Rows[fila].Cells[5].Value = error;
                            c++;
                        }
                        Evaluacion(xi, xu, xr, valor, error, c);
                    }
                }
                if (caso == 3)
                {
                    if (c > NumIteracion)
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(xi) * ADF.EvaluaFx(xr) > 0)
                            {
                                xi = xr;
                            }
                            else
                            {
                                xu = xr;
                            }
                            xr = ValorXr(xi, xu);
                            XRFINAL = xr;
                            double errorP = Error_Porcentual(xr, e);
                            double errorV = Error_Verdadero(xr, e);
                            errorP = Math.Round(errorP, CifrasRedondeoEP);
                            errorV = Math.Round(errorV, CifrasRedondeoEV);
                            ERRORPFINAL = errorP;
                            ERRORVFINAL = errorV;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = xi;
                            dgvTabla.Rows[fila].Cells[2].Value = xu;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = errorP;
                            dgvTabla.Rows[fila].Cells[5].Value = errorV;
                            c++;
                        }
                        Evaluacion(xi, xu, xr, valor, error, c);
                    }
                }
            }
            catch
            {
                MessageBox.Show("||ERROR: EL SISTEMA SE AH SOBRECARGADO :(");
            }
        }

        //METODO BISECCION_METODO BISECCION_METODO BISECCION_METODO BISECCION_METODO BISECCION_METODO BISECCION_
        private void Biseccion()
        {
            //lstVer.Items.Clear();
            dgvTabla.Rows.Clear();
            if (txtFuncion.Text == "")
            {
                MessageBox.Show("||FUNCION NO ESTABLECIDA||");
                return;
            }
            else if (txtA.Text == "" && txtB.Text == "")
            {
                MessageBox.Show("||INTERVALOS NO ESTABLECIDOS||");
                return;
            }
            else
            {
                try
                {
                    string valor = txtFuncion.Text;
                    double a = Convert.ToDouble(txtA.Text);
                    double b = Convert.ToDouble(txtB.Text);
                    if (ADF.Sintaxis(valor, 'x')) //pasamos la funcion con la variable a evaluar
                    {
                        double xr = (a + b) / 2;
                        int fila = dgvTabla.Rows.Add();
                        dgvTabla.Rows[fila].Cells[0].Value = "1";
                        dgvTabla.Rows[fila].Cells[1].Value = a;
                        dgvTabla.Rows[fila].Cells[2].Value = b;
                        dgvTabla.Rows[fila].Cells[3].Value = xr;
                        dgvTabla.Rows[fila].Cells[4].Value = "N/A";
                        dgvTabla.Rows[fila].Cells[5].Value = "N/A";
                        double error = 0;
                        if (caso == 1)
                            error = 100;
                        if (caso == 2)
                            error = 0.01;
                        if (caso == 3)
                            error = NumIteracion;
                        Evaluacion2(a, b, xr, valor, error, 2);
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA SINTAXIS DE LA FUNCIÓN");  // aquí mensaje de error en sintaxis
                    }
                }
                catch
                {
                    MessageBox.Show("||ERROR NO IDENTIFICADO||");
                }
            }
            //lstVer.SelectedIndex = lstVer.Items.Count - 1;
            //lstVer.SelectedIndex = -1;
        }
        private void Evaluacion2(double a, double b, double xr, string valor, double error, int c)
        {
            try
            {
                if (caso == 1)
                {
                    if (error < ErrorPL)        //Caso base
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {                           //Caso general
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(a) * ADF.EvaluaFx(xr) > 0)
                            {
                                a = xr;
                            }
                            else
                            {
                                b = xr;
                            }
                            xr = Math.Round((a + b) / 2, CifrasRedondeo);
                            XRFINAL = xr;
                            error = Error_Porcentual(e, xr);
                            double errorV = Error_Verdadero(e, xr);
                            error = Math.Round(error, CifrasRedondeoEP);
                            errorV = Math.Abs(Math.Round(errorV, CifrasRedondeoEV));
                            ERRORPFINAL = error;
                            ERRORVFINAL = errorV;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = a;
                            dgvTabla.Rows[fila].Cells[2].Value = b;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = error;
                            dgvTabla.Rows[fila].Cells[5].Value = errorV;
                            c++;
                        }
                        Evaluacion2(a, b, xr, valor, error, c);
                    }
                }       //Seleccion por Error porcentual
                if (caso == 2)
                {
                    if (error < ErrorVL)
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(a) * ADF.EvaluaFx(xr) > 0)
                            {
                                a = xr;
                            }
                            else
                            {
                                b = xr;
                            }
                            xr = Math.Round((a + b) / 2, CifrasRedondeo);
                            XRFINAL = xr;
                            double errorP = Error_Porcentual(e, xr);
                            errorP = Math.Round(errorP, CifrasRedondeoEP);
                            error = Error_Verdadero(e, xr);
                            error = Math.Abs(Math.Round(error, CifrasRedondeoEV));
                            ERRORPFINAL = errorP;
                            ERRORVFINAL = error;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = a;
                            dgvTabla.Rows[fila].Cells[2].Value = b;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = errorP;
                            dgvTabla.Rows[fila].Cells[5].Value = error;
                            c++;
                        }
                        Evaluacion2(a, b, xr, valor, error, c);
                    }
                }       //Seleccion por Error verdadero
                if (caso == 3)
                {
                    if (c > NumIteracion)
                    {
                        txtRA.Text = Convert.ToString(XRFINAL);
                        txtER.Text = Convert.ToString(ERRORPFINAL);
                        txtEV.Text = Convert.ToString(ERRORVFINAL);
                        return;
                    }
                    else
                    {
                        double e = xr;
                        if (ADF.Sintaxis(valor, 'x'))
                        {
                            if (ADF.EvaluaFx(a) * ADF.EvaluaFx(xr) > 0)
                            {
                                a = xr;
                            }
                            else
                            {
                                b = xr;
                            }
                            xr = Math.Round((a + b) / 2, CifrasRedondeo);
                            XRFINAL = xr;
                            double errorP = Error_Porcentual(e, xr);
                            double errorV = Error_Verdadero(e, xr);
                            errorP = Math.Round(errorP, CifrasRedondeoEP);
                            errorV = Math.Abs(Math.Round(errorV, CifrasRedondeoEV));
                            ERRORPFINAL = errorP;
                            ERRORVFINAL = errorV;
                            int fila = dgvTabla.Rows.Add();
                            dgvTabla.Rows[fila].Cells[0].Value = c;
                            dgvTabla.Rows[fila].Cells[1].Value = a;
                            dgvTabla.Rows[fila].Cells[2].Value = b;
                            dgvTabla.Rows[fila].Cells[3].Value = xr;
                            dgvTabla.Rows[fila].Cells[4].Value = errorP;
                            dgvTabla.Rows[fila].Cells[5].Value = errorV;
                            c++;
                        }
                        Evaluacion2(a, b, xr, valor, error, c);
                    }
                }       //Seleccion por Numero de Iteracion
            }
            catch
            {
                MessageBox.Show("ERROR: EL SISTEMA SE HA SOBRECARGADO :(");
            }
        }

        //ERROR_ERROR_ERROR
        private double Error_Porcentual(double xr1, double xr2)
        {
            double e = ((xr1 - xr2) / xr1) * 100;
            e = Math.Abs(e);
            return e;
        }
        private double Error_Verdadero(double xr1, double xr2)
        {
            double e = xr1 - xr2;
            e = Math.Abs(e);
            return e;
        }

        //BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_BOTONES_
        private void Btn0_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "0";
            txtFuncion.Text = valor;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "1";
            txtFuncion.Text = valor;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "2";
            txtFuncion.Text = valor;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "3";
            txtFuncion.Text = valor;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "4";
            txtFuncion.Text = valor;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "5";
            txtFuncion.Text = valor;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "6";
            txtFuncion.Text = valor;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "7";
            txtFuncion.Text = valor;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "8";
            txtFuncion.Text = valor;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "9";
            txtFuncion.Text = valor;
        }
        private void BtnExponencial_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "^";
            txtFuncion.Text = valor;
        }
        private void BtnCorcheteAbre_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "(";
            txtFuncion.Text = valor;
        }
        private void BtnCorcheteCierra_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + ")";
            txtFuncion.Text = valor;
        }
        private void BtnMas_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "+";
            txtFuncion.Text = valor;
        }
        private void BtnMenos_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "-";
            txtFuncion.Text = valor;
        }
        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "*";
            txtFuncion.Text = valor;
        }
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "/";
            txtFuncion.Text = valor;
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "x";
            txtFuncion.Text = valor;
        }
        private void BtnPunto_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + ".";
            txtFuncion.Text = valor;
        }
        private void BtnSeno_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "sen(";
            txtFuncion.Text = valor;
        }
        private void BtnCoseno_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "cos(";
            txtFuncion.Text = valor;
        }
        private void BtnTangente_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "tan(";
            txtFuncion.Text = valor;
        }
        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            string valor = txtFuncion.Text;
            valor = valor + "sqr(";
            txtFuncion.Text = valor;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtFuncion.Text = txtFuncion.Text.Remove(txtFuncion.Text.Length - 1);
            }
            catch { }
        }
        private void BtnAC_Click(object sender, EventArgs e)
        {
            txtFuncion.Text = "";
        }

        //VALIDACIONDETECLADO_VALIDACIONDETECLADO_VALIDACIONDETECLADO_VALIDACIONDETECLADO_VALIDACIONDETECLADO_
        private void CbxPreferencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cbx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cbx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
