/*
* PRÁCTICA.............: Práctica 10.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones Formulario III. Puerto Serie y Uso Dll’s.
* FECHA DE ENTREGA.....: 02 de Febrero de 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CaracteristicasPuerto
{
    public class Caracteristicas
    {
        public void StopBit(string nombre, SerialPort puerto )
        {
            if (nombre == "None")
            {
                puerto.StopBits = StopBits.None;
            }
            else if (nombre == "One")
            {
                puerto.StopBits = StopBits.One;
            }
            else if (nombre == "Two")
            {
                puerto.StopBits = StopBits.Two;
            }
            else if (nombre == "OnePointFive")
            {
                puerto.StopBits = StopBits.OnePointFive;
            }
        }
        public void ParidadBit(string nombre, SerialPort puerto)
        {
            if (nombre == "None")
            {
                puerto.Parity = Parity.None;
            }
            else if (nombre == "Odd")
            {
                puerto.Parity = Parity.Odd;
            }
            else if (nombre == "Even")
            {
                puerto.Parity = Parity.Even;
            }
            else if (nombre == "Mark")
            {
                puerto.Parity = Parity.Mark;
            }
            else if (nombre == "Space")
            {
                puerto.Parity = Parity.Space;
            }
        }
    }
}
