using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tWord = System.UInt16;
using tByte = System.Byte;

namespace CRC_Sample
{
    class Program
    {
        byte[] BUFF_2_T = {}; // example data

        static void Main(string[] args)
        {
            byte slaveAddress = 2;
            byte functionCode = 6;
            ushort startAddress = 4;
            ushort numberOfPoints = 5000;

            // Build Message (FC03).

            byte[] frame = new byte[8];
            frame[0] = slaveAddress;
            frame[1] = functionCode;
            frame[2] = (byte)(startAddress >> 8);
            frame[3] = (byte)startAddress;
            frame[4] = (byte)(numberOfPoints >> 8);
            frame[5] = (byte)numberOfPoints;
            byte[] checkSum = CRC16(frame);
            frame[6] = checkSum[0];
            frame[7] = checkSum[1];
            // print.
            foreach (var item in frame)
            {
                Console.Write(string.Format("{0:X2} ", item)); // kieu hex 2 chu so
            }
            Console.ReadKey();
        }

        private static byte[] CRC16(byte[] data)
        {
            byte[] checkSum = new byte[2];
            ushort reg_crc = 0XFFFF;
            for (int i = 0; i < data.Length - 2; i++)
            {
                reg_crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((reg_crc & 0x01) == 1)
                    {
                        reg_crc = (ushort)((reg_crc >> 1) ^ 0xA001);
                    }
                    else
                    {
                        reg_crc = (ushort)(reg_crc >> 1);
                    }
                }
            }
            checkSum[1] = (byte)((reg_crc >> 8) & 0xFF);
            checkSum[0] = (byte)(reg_crc & 0xFF);
            return checkSum;
        }

        tWord CRC16_Check_A(tByte Num) //Ham CRC 16
        {
            tByte x, y, i; tWord Crc; //Bien Cuc Bo

            Crc = 0xFFFF; //Init

            for (x = 0; x < Num; ++x) //Lap Vong
            {
                y = BUFF_2_T[x]; //Lay Byte Trong Bo Dem CRC 16
                Crc = (tWord)(Crc ^ y); //Calculate the CRC

                for (i = 8; i != 0; --i) //Shift Right
                {
                    if ((Crc & 0x0001) != 0) //If the LSB is set
                    {
                        Crc >>= 1; //Shift right and XOR 0xA001
                        Crc ^= 0xA001;
                    }
                    else //Else LSB is not set  
                    {
                        Crc >>= 1; //Just shift right
                    }
                }
            }

            //Swapping of the high and low CRC bytes      
            return Crc; //Tra Ve CRC_16 Tinh Duoc
        }
    }
}
