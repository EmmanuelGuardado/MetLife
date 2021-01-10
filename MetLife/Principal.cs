using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SpreadsheetLight;
using Keys = OpenQA.Selenium.Keys;
using System.Threading;

namespace MetLife
{
    public partial class Principal : Form
    {


        public Principal()
        {
            InitializeComponent();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {

        }
        private List<PolizaViewModel> CargarLista(string path)
        {
            SLDocument sl = new SLDocument(path);

            List<PolizaViewModel> lst = new List<PolizaViewModel>();
            int col = 1;
            int row = 2;
            int id = 1;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(row, col)))
            {
                PolizaViewModel p = new PolizaViewModel();
                p.CodigoPoliza = sl.GetCellValueAsString(row, col);
                p.Id = id;
                lst.Add(p);

                row++;
                id++;
            }
            return lst;
        }
        private void GenerarExcelGM(List<DatosNuevosGMViewModel> lstDatosGM)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFile = saveFileDialog1.FileName;

                SLDocument sl = new SLDocument();

                DataTable dt = new DataTable();
                dt.Columns.Add("Póliza", typeof(string));
                dt.Columns.Add("Promotoria", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Fecha de emision de póliza", typeof(string));
                dt.Columns.Add("IDNominal", typeof(string));
                dt.Columns.Add("Retenedor", typeof(string));
                dt.Columns.Add("Unidad de pago", typeof(string));
                dt.Columns.Add("Concepto de descuento", typeof(string));
                dt.Columns.Add("Plan", typeof(string));
                dt.Columns.Add("Prima al cobro", typeof(string));
                dt.Columns.Add("Fecha de último descuento", typeof(string));
                dt.Columns.Add("Año/Quincena último descuento", typeof(string));
                dt.Columns.Add("Importe último descuento", typeof(string));
                dt.Columns.Add("Último incremento", typeof(string));
                dt.Columns.Add("Último retiro de reserva", typeof(string));
                dt.Columns.Add("Monto de reserva", typeof(string));
                dt.Columns.Add("Monto de fondo de inversión", typeof(string));
                dt.Columns.Add("Recibos pendientes", typeof(string));
                dt.Columns.Add("MRP", typeof(double));
                dt.Columns.Add("Estatus", typeof(string));

                foreach (var d in lstDatosGM)
                {
                    dt.Rows.Add(d.CodigoPoliza, d.Promotoria, d.Cliente, d.RFC, d.FechaEmisionPoliza, d.IDNominal, d.Retenedor, d.UnidadPago, d.ConceptoDescuento,
                        d.Plan, d.PrimaAlCobro, d.FechaUltimoDescuento, d.AQUltimoDescuento, d.ImporteUltimoDescuento, d.UltimoIncremento, d.UltimoRetiroReserva,
                        d.MontoReserva, d.MontoFondoInversion, d.RecibosPendientes, d.MRP, d.Estatus);
                }

                sl.ImportDataTable(1, 1, dt, true);
                sl.SaveAs(pathFile);
            }
        }
        private void GenerarExcelGR(List<DatosNuevosGRViewModel> lstDatos)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFile = saveFileDialog1.FileName;

                SLDocument sl = new SLDocument();

                DataTable dt = new DataTable();
                dt.Columns.Add("Poliza", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Nombre completo", typeof(string));
                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Fecha de nacimiento", typeof(string));
                dt.Columns.Add("Edad", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Celular", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Calle", typeof(string));
                dt.Columns.Add("NoExt", typeof(string));
                dt.Columns.Add("NoInt", typeof(string));
                dt.Columns.Add("CP", typeof(string));
                dt.Columns.Add("Población", typeof(string));
                dt.Columns.Add("Colonia", typeof(string));
                dt.Columns.Add("Nombre empresa", typeof(string));
                dt.Columns.Add("Ocupación", typeof(string));
                dt.Columns.Add("Sub-Zona", typeof(string));
                dt.Columns.Add("Tel-Lab", typeof(string));
                dt.Columns.Add("Zona", typeof(string));

                foreach (var d in lstDatos)
                {
                    dt.Rows.Add(d.CodigoPoliza, d.Estatus, d.NombreCompleto, d.RFC, d.FechaNacimiento,
                        d.Edad, d.Telefono, d.Celular, d.Email, d.Calle, d.NoExt, d.NoInt, d.CP, d.Poblacion,
                        d.Colonia, d.NombreEmpresa, d.Ocupacion, d.SubZona, d.TelLab, d.Zona);
                }
                sl.ImportDataTable(1, 1, dt, true);
                sl.SaveAs(pathFile);
            }
        }
        List<DatosNuevosGMViewModel> lstDatosGM = new List<DatosNuevosGMViewModel>();
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btnAbrirArchivo_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                //se carga el archivo excel con las polizas a una lista
                List<PolizaViewModel> listPolizas = CargarLista(path);
                txtTotal.Text = listPolizas.Count.ToString();
                //PolizasFaltantesGM = listPolizas;
                try
                {
                    IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
                    //Se abre Chrome, accede a la pagina y maximiza la ventana del navegador
                    driver.Navigate().GoToUrl("https://servicios.metlife.com.mx/wps/portal/agentesDXN/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vM0Q_0yU9PT03xLy3RL0hXVAQAEl7pog!!/");
                    driver.Manage().Window.Maximize();
                    //asigna los valores a los cuadros de texto para iniciar sesión
                    IWebElement inputUsuario = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/table[1]/tbody/tr[1]/td/input"));
                    inputUsuario.SendKeys(txtUsuario.Text);
                    IWebElement inputClave = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/table[1]/tbody/tr[2]/td/input"));
                    inputClave.SendKeys(txtContrasena.Text);
                    //simula el click del raton
                    IWebElement buttonIngresar = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/table[2]/tbody/tr/td/input"));
                    buttonIngresar.Click();

                    foreach (var p in listPolizas)
                    {
                        txtActual.Text = p.Id.ToString();
                        IWebElement tabConsulta = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/ul/li[2]/a/span"));
                        tabConsulta.Click();
                        IWebElement inputPoliza = driver.FindElement(By.Name("numeroPoliza"));
                        inputPoliza.SendKeys(p.CodigoPoliza);
                        IWebElement buttonBuscar = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div/div[2]/table/tbody/tr[3]/td/input"));
                        buttonBuscar.Click();
                        IWebElement inputPoliza2 = driver.FindElement(By.Name("numeroPoliza"));
                        inputPoliza2.Clear();

                        DatosNuevosGMViewModel dn = new DatosNuevosGMViewModel();
                        dn.Estatus = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/div[2]/div[1]/div[2]/table/tbody/tr[3]/td")).Text;
                        dn.CodigoPoliza = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/div[2]/div[1]/div[2]/table/tbody/tr[2]/td")).Text;
                        if (dn.Estatus == "M" || dn.Estatus == "I")
                        {
                            lstDatosGM.Add(new DatosNuevosGMViewModel
                            {
                                CodigoPoliza = p.CodigoPoliza,
                                Promotoria = "",
                                Cliente = "",
                                RFC = "",
                                FechaEmisionPoliza = "",
                                Estatus = "CANCELADO",
                                IDNominal = "",
                                Retenedor = "",
                                UnidadPago = "",
                                ConceptoDescuento = "",
                                Plan = "",
                                PrimaAlCobro = "",
                                FechaUltimoDescuento = "",
                                AQUltimoDescuento = "",
                                ImporteUltimoDescuento = "",
                                UltimoIncremento = "",
                                UltimoRetiroReserva = "CANCEL",
                                MontoReserva = "",
                                MontoFondoInversion = "",
                                RecibosPendientes = ""

                            });
                            continue;
                        }

                        IWebElement aAbrirRegistro = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div/form/div/div[2]/div[2]/div[1]/div[2]/table/tbody/tr[4]/td/a"));
                        aAbrirRegistro.Click();

                        dn.Promotoria = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[1]/td")).Text;
                        dn.Cliente = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[2]/td")).Text;
                        dn.RFC = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[3]/td")).Text;
                        dn.FechaEmisionPoliza = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[5]/td")).Text;
                        dn.IDNominal = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[7]/td")).Text;
                        dn.Retenedor = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[8]/td")).Text;
                        dn.UnidadPago = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[9]/td")).Text;
                        dn.ConceptoDescuento = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[10]/td")).Text;
                        dn.Plan = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[11]/td")).Text;
                        dn.PrimaAlCobro = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[2]/div[2]/table/tbody/tr[12]/td")).Text;

                        Actions action = new Actions(driver);
                        action.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();

                        dn.FechaUltimoDescuento = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[1]/td")).Text;
                        dn.AQUltimoDescuento = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[2]/td")).Text;

                        dn.ImporteUltimoDescuento = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[3]/td")).Text;
                        dn.UltimoIncremento = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[4]/td")).Text;

                        dn.UltimoRetiroReserva = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[5]/td")).Text;
                        dn.MontoReserva = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[6]/td")).Text;
                        dn.MontoFondoInversion = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[7]/td")).Text;
                        dn.RecibosPendientes = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[4]/div[2]/table/tbody/tr[8]/td")).Text;

                        action.KeyUp(Keys.Control).SendKeys(Keys.Home).Perform();

                        if (dn.UltimoIncremento == "")
                        {
                            dn.UltimoIncremento = "NUNCA";
                        }
                        else
                        {
                            dn.UltimoIncremento = ConcatenarFecha(dn.UltimoIncremento);
                        }
                        if (dn.UltimoRetiroReserva == "") 
                        {
                            dn.UltimoRetiroReserva = "NUNCA";
                        }
                        else
                        {
                            dn.UltimoRetiroReserva = ConcatenarFecha(dn.UltimoRetiroReserva);
                        }

                        if (dn.Promotoria != "ME" && dn.Promotoria != "KC")
                        {
                            dn.UltimoRetiroReserva = "DIF PROMO";
                        }

                        string nueva_recibospendinetes = dn.RecibosPendientes.Replace('$', ' ');
                        string nueva_primacobro = dn.PrimaAlCobro.Replace('$', ' ');

                        if (this.CalcularMRP(double.Parse(nueva_recibospendinetes), double.Parse(nueva_primacobro)) > 10)
                        {
                            dn.UltimoRetiroReserva = "MRP";
                        }
                        dn.MRP = this.CalcularMRP(double.Parse(nueva_recibospendinetes), double.Parse(nueva_primacobro));
                        lstDatosGM.Add(dn);
                        IWebElement aAnterior = driver.FindElement(By.XPath("/html/body/div/div[2]/table/tbody/tr/td/table/tbody/tr/td/div[1]/form/div/div[1]/a[1]/b"));
                        aAnterior.Click();
                        p.Id += 1;                        
                    }
                    driver.Close();
                    driver.Quit();
                    MessageBox.Show("Proceso terminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + "Error detectado");
                }
                GenerarExcelGM(lstDatosGM);
            }
        }
        //Función que asigna dia 01 a todas las fechas
        private string ConcatenarFecha(string fecha)
        {
            //Separa las fechas por cada '-'
            string[] subcadenas = fecha.Split('-');
            //Remplaza la primer subcadena por el digito 01
            string nueva_cadena = subcadenas[0].Replace(subcadenas[0], "01");
            // Devuelve la fecha concatenada 
            return nueva_cadena + "-" + subcadenas[1] + "-" + subcadenas[2];
        }
        //Función que calcula el mrp
        public double CalcularMRP(double recibos_pendientes, double prima_cobro)
        {
            double mrp = recibos_pendientes / prima_cobro;
            return mrp;
        }

        List<DatosNuevosGRViewModel> lstDatosGR = new List<DatosNuevosGRViewModel>();
        private void btnAbrirArchivo2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;


                //se carga el archivo excel con las polizas a una lista
                List<PolizaViewModel> listPolizas = CargarLista(path);
                try
                {
                    IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
                    //Se abre Chrome, accede a la pagina y maximiza la ventana del navegador
                    driver.Navigate().GoToUrl("https://gruporegio.sipac.mx/");
                    //asigna los valores a los cuadros de texto para iniciar sesión
                    IWebElement inputUsuario = driver.FindElement(By.Id("Usuario"));
                    inputUsuario.SendKeys(txtUsuario2.Text);
                    IWebElement inputContrasena = driver.FindElement(By.Id("Contrasena"));
                    inputContrasena.SendKeys(txtContrasena2.Text);
                    //simula el click del raton
                    IWebElement buttonEntrar = driver.FindElement(By.Id("Entrar"));
                    buttonEntrar.Click();
                    driver.Navigate().GoToUrl("https://gruporegio.sipac.mx/sipac/agentes/ventas/consulta.php");
                    driver.Manage().Window.Maximize();

                    foreach (var p in listPolizas)
                    {
                        IWebElement inputPoliza = driver.FindElement(By.Id("busqueda"));
                        inputPoliza.SendKeys(p.CodigoPoliza);
                        IWebElement buttonBuscar = driver.FindElement(By.Name("Buscar"));
                        buttonBuscar.Click();

                        DatosNuevosGRViewModel dn = new DatosNuevosGRViewModel();

                        Thread.Sleep(1000); //Cambiar tiempo para reducirlo

                        dn.CodigoPoliza = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[1]/td/input")).GetAttribute("value");
                        dn.Estatus = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[2]/td/table/tbody/tr[2]/td/input")).GetAttribute("value");
                        dn.NombreCompleto = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[2]/td/table/tbody/tr[4]/td/input")).GetAttribute("value");
                        dn.RFC = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[2]/td/table/tbody/tr[6]/td[1]/input")).GetAttribute("value");
                        dn.FechaNacimiento = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[2]/td/table/tbody/tr[6]/td[2]/input")).GetAttribute("value");
                        dn.Edad = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[2]/td/table/tbody/tr[6]/td[3]/input")).GetAttribute("value");
                        dn.Telefono = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[3]/td/table/tbody/tr[2]/td[1]/input")).GetAttribute("value");
                        dn.Celular = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[3]/td/table/tbody/tr[2]/td[2]/input")).GetAttribute("value");
                        dn.Email = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[3]/td/table/tbody/tr[2]/td[3]/input")).GetAttribute("value");
                        dn.Calle = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[3]/td[1]/input")).GetAttribute("value");
                        dn.NoExt = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[3]/td[2]/input")).GetAttribute("value");
                        dn.NoInt = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[3]/td[3]/input")).GetAttribute("value");
                        dn.CP = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[3]/td[4]/input")).GetAttribute("value");
                        dn.Poblacion = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[5]/td[1]/input")).GetAttribute("value");
                        dn.Colonia = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[4]/td/table/tbody/tr[5]/td[2]/input")).GetAttribute("value");
                        dn.NombreEmpresa = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[5]/td/table/tbody/tr[3]/td[1]/input")).GetAttribute("value");
                        dn.Ocupacion = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[5]/td/table/tbody/tr[3]/td[2]/input")).GetAttribute("value");
                        dn.SubZona = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[5]/td/table/tbody/tr[5]/td[1]/input")).GetAttribute("value");
                        dn.TelLab = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[5]/td/table/tbody/tr[5]/td[2]/input")).GetAttribute("value");
                        dn.Zona = driver.FindElement(By.XPath("/html/body/form/div/div[2]/table[1]/tbody/tr[5]/td/table/tbody/tr[7]/td/span/input")).GetAttribute("value");

                        lstDatosGR.Add(dn);
                        IWebElement buttonRegresar = driver.FindElement(By.Id("Regresar"));
                        buttonRegresar.Click();
                    }
                    driver.Close();
                    driver.Quit();
                    MessageBox.Show("Proceso terminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"\n"+"Error detectado");
                    
                }
                GenerarExcelGR(lstDatosGR);
            }
        }
        
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //    //notifyIcon1.Icon = SystemIcons.Application;
            //    notifyIcon1.BalloonTipText = "Aplicación en segundo plano";
            //    notifyIcon1.ShowBalloonTip(1000);
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Show();
            //notifyIcon1.BalloonTipText = "Aplicación en primer plano";
            //notifyIcon1.ShowBalloonTip(1000);
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Show();
            //notifyIcon1.BalloonTipText = "Aplicación en primer plano";
            //notifyIcon1.ShowBalloonTip(1000);
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();

            //}
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
