/*
* PRÁCTICA.............: Práctica 10.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones Formulario III. Puerto Serie y Uso Dll’s.
* FECHA DE ENTREGA.....: 02 de Febrero de 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using CaracteristicasPuerto;

namespace Proyecto10
{
    public partial class frmPuertos : Form
    {
        static SerialPort puerto = new SerialPort();
        private string DispString;
        static byte[] mBuffer;
        static bool activo = false;
        private string fichero;
        byte[] bytesSize;
        int bytesRead;
        public frmPuertos()
        {
            InitializeComponent();
            string[] portNames = SerialPort.GetPortNames();
            for (int i = 0; i < portNames.Length; i++)
            {
                cboPuertos.Items.Add(portNames[i]);
            }
            
        }

        private void frmPuertos_Load(object sender, EventArgs e)
        {

        }

        private void btnArirPuerto_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (cboPuertos.SelectedIndex.Equals(-1))
            {
                erpPuertos.SetError(cboPuertos, "Seleccionar Puerto");
                contador++;
            }
            else
            {
                erpPuertos.Clear();
            }
            if (cboVelocidad.SelectedIndex.Equals(-1))
            {
                erpPuertos.SetError(cboVelocidad, "Seleccionar Velocidad");
                contador++;
            }
            else
            {
                erpPuertos.Clear();
            }
            if (cboBit.SelectedIndex.Equals(-1))
            {
                erpPuertos.SetError(cboBit, "Seleccionar Número de Bits");
                contador++;
            }
            else
            {
                erpPuertos.Clear();
            }
            if (cboStop.SelectedIndex.Equals(-1))
            {
                erpPuertos.SetError(cboStop, "Seleccionar Número de Bit Stop");
                contador++;
            }
            else
            {
                erpPuertos.Clear();
            }
            if (cboParidad.SelectedIndex.Equals(-1))
            {
                erpPuertos.SetError(cboParidad, "Seleccionar Número de Bit Paridad");
                contador++;
            }
            else
            {
                erpPuertos.Clear();
            }
            if (contador == 0)
            {
                try
                {
                    Caracteristicas caracteristicas = new Caracteristicas();
                    puerto.PortName = cboPuertos.SelectedItem.ToString();
                    puerto.BaudRate = int.Parse(cboVelocidad.SelectedItem.ToString());
                    puerto.DataBits = int.Parse(cboBit.SelectedItem.ToString());
                    caracteristicas.StopBit(cboStop.SelectedItem.ToString(), puerto);
                    caracteristicas.ParidadBit(cboParidad.SelectedItem.ToString(), puerto);
                    puerto.Open();
                    this.Size = new Size(575, 410);
                    txtChat.Text = "Conectado: " + puerto.PortName.ToString() + "\r\n";
                    puerto.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                }
                catch (Exception )
                {
                    MessageBox.Show("Mala configuración del puerto o el puerto ya está abierto");
                }
            }
        }
        private void btnCerrarPuerto_Click(object sender, EventArgs e)
        {
            if (puerto.IsOpen)
            {
                puerto.Close();
                txtChat.Text += "Puerto " + puerto.PortName.ToString() + " cerrado\r\n";
                this.Size = new Size(275, 410);
            }
            else
            {
                MessageBox.Show("Puerto ya cerrado");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (puerto.IsOpen)
            {
                puerto.WriteLine(txtEnviar.Text);
                txtChat.Text += "Envia: " + txtEnviar.Text.ToString() + "\r\n";
            }
            else
            {
                MessageBox.Show("El puerto está cerrado");
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (activo == true)
            {
                bytesSize = new byte[puerto.ReadBufferSize];
                bytesRead = puerto.Read(bytesSize, 0, bytesSize.Length);
            }
            else
            {
                DispString = puerto.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }
        }
        private void DisplayText(object sender, EventArgs e)
        {
            txtChat.AppendText("Recibe: " + DispString + "\r\n");
        }
        private void btnEnviarFichero_Click(object sender, EventArgs e)
        {
            if (puerto.IsOpen)
            {
                try
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "Archivo .txt|*.txt";
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                    openFileDialog1.FileName.Length > 0)
                    {
                        string[] nombreFichero = openFileDialog1.FileName.Split('\\');
                        string texto = File.ReadAllText(@"" + openFileDialog1.FileName);
                        mBuffer = Encoding.ASCII.GetBytes(texto);
                        puerto.Write(mBuffer, 0, mBuffer.Length);
                        fichero = nombreFichero[nombreFichero.Length - 1];
                    }
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show("Extension no válida");
                }
            }
            else
            {
                MessageBox.Show("El puerto está cerrado");
            }
        }
        private void btnRecibirFichero_Click(object sender, EventArgs e)
        {
            if (bytesSize != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivo .txt|*.txt";
                string fileName = string.Empty;
                if (fileName == string.Empty)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        fileName = saveFileDialog1.FileName;
                }
                if (fileName != string.Empty)
                {
                    File.WriteAllBytes(@"" + fileName, bytesSize);
                }
                bytesSize = null;

            }
            else
            {

                MessageBox.Show("No hay archivo que recibir");
            }
        }

        private void btnActivarChat_Click(object sender, EventArgs e)
        {
            txtChat.Enabled = true;
            btnEnviar.Enabled = true;
            txtEnviar.Enabled = true;
            btnEnviarFichero.Enabled = false;
            btnRecibirFichero.Enabled = false;
            activo = false;
        }

        private void btnActivarTransferencia_Click(object sender, EventArgs e)
        {
            btnEnviarFichero.Enabled = true;
            btnRecibirFichero.Enabled = true;
            txtChat.Enabled = false;
            btnEnviar.Enabled = false;
            txtEnviar.Enabled = false;
            activo = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            acercaDe.Show();
        }
    }
}
