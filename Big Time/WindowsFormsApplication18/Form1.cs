using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
       
        int culoare;
        int culinceput;
        int[,] a;
        int[,] b;
       
       int sfarsit ;
        int[] x4;
        int n4;
        int[] a2;
        int[] rezolvare;
        int validprod;
        int reusit = 0;
        int aux = 0;
        public Form1()
        {
            a = new int[8, 8];
            b = new int[8, 8];
            rezolvare = new int[242];
            x4 = new int[242];
            a2 = new int[245];
            for (int i = 1; i < 200; i++)
                a2[i] = 4;
            InitializeComponent();
            timer1.Stop();
        }
        private void Valid()////validarea produsului cartezian (ex 1 2 3 4 )
        {
            validprod = 1;
            int i;
            if (x4[1] == culinceput) validprod = 0;
            else
                for (i = 1; i <= n4 - 1; i++)
                    if (x4[i] == x4[i + 1]) validprod = 0;
            
            
        }

        private void mata()
        {
            int i; int j;
            for (i = 1; i < 8; i++)
                for (j = 1; j < 8; j++)
                    a[i, j] = b[i, j];
        }
        private void matb()
        {
            int i; int j;
            for (i = 1; i < 8; i++)
                for (j = 1; j < 8; j++)
                    b[i, j] = a[i, j];
        }
        private void verificare()
        {
            sfarsit = 0;
            int i; int j;
            
            for (i = 1; i < 8; i++)
                for (j = 1; j < 8; j++)
                    if (a[i, j] < 5) sfarsit = 1;
    
        }
        private void textbuton()
        {
            button1.Text = ""+a[1, 1];
            button2.Text = "" + a[1, 2];
            button3.Text = "" + a[1, 3];
            button4.Text = "" + a[1, 4];
            button5.Text = "" + a[1, 5];
            button6.Text = "" + a[1, 6];
            button7.Text = "" + a[1, 7];

            button8.Text = "" + a[2, 1];
            button9.Text = "" + a[2, 2];
            button10.Text = "" + a[2, 3];
            button11.Text = "" + a[2, 4];
            button12.Text = "" + a[2, 5];
            button13.Text = "" + a[2, 6];
            button14.Text = "" + a[2, 7];

            button15.Text = "" + a[3, 1];
            button16.Text = "" + a[3, 2];
            button17.Text = "" + a[3, 3];
            button18.Text = "" + a[3, 4];
            button19.Text = "" + a[3, 5];
            button20.Text = "" + a[3, 6];
            button21.Text = "" + a[3, 7];

            button22.Text = "" + a[4, 1];
            button23.Text = "" + a[4, 2];
            button24.Text = "" + a[4, 3];
            button25.Text = "" + a[4, 4];
            button26.Text = "" + a[4, 5];
            button27.Text = "" + a[4, 6];
            button28.Text = "" + a[4, 7];

            button29.Text = "" + a[5, 1];
            button30.Text = "" + a[5, 2];
            button31.Text = "" + a[5, 3];
            button32.Text = "" + a[5, 4];
            button33.Text = "" + a[5, 5];
            button34.Text = "" + a[5, 6];
            button35.Text = "" + a[5, 7];

            button36.Text = "" + a[6, 1];
            button37.Text = "" + a[6, 2];
            button38.Text = "" + a[6, 3];
            button39.Text = "" + a[6, 4];
            button40.Text = "" + a[6, 5];
            button41.Text = "" + a[6, 6];
            button42.Text = "" + a[6, 7];

            button43.Text = "" + a[7, 1];
            button44.Text = "" + a[7, 2];
            button45.Text = "" + a[7, 3];
            button46.Text = "" + a[7, 4];
            button47.Text = "" + a[7, 5];
            button48.Text = "" + a[7, 6];
            button49.Text = "" + a[7, 7];
        
        }
        private void coloreaza2(int i, int j)
        {
            if (a[i, j] == 0)
            {
                if (i == 1)
                {
                    if (j == 1) button1.BackColor = button55.BackColor;
                    if (j == 2) button2.BackColor = button55.BackColor;
                    if (j == 3) button3.BackColor = button55.BackColor;
                    if (j == 4) button4.BackColor = button55.BackColor;
                    if (j == 5) button5.BackColor = button55.BackColor;
                    if (j == 6) button6.BackColor = button55.BackColor;
                    if (j == 7) button7.BackColor = button55.BackColor;
                }
                else
                    if (i == 2)
                    {
                        if (j == 1) button8.BackColor = button55.BackColor;
                        if (j == 2) button9.BackColor = button55.BackColor;
                        if (j == 3) button10.BackColor = button55.BackColor;
                        if (j == 4) button11.BackColor = button55.BackColor;
                        if (j == 5) button12.BackColor = button55.BackColor;
                        if (j == 6) button13.BackColor = button55.BackColor;
                        if (j == 7) button14.BackColor = button55.BackColor;
                    }
                    else
                        if (i == 3)
                        {
                            if (j == 1) button15.BackColor = button55.BackColor;
                            if (j == 2) button16.BackColor = button55.BackColor;
                            if (j == 3) button17.BackColor = button55.BackColor;
                            if (j == 4) button18.BackColor = button55.BackColor;
                            if (j == 5) button19.BackColor = button55.BackColor;
                            if (j == 6) button20.BackColor = button55.BackColor;
                            if (j == 7) button21.BackColor = button55.BackColor;
                        }
                        else
                            if (i == 4)
                            {
                                if (j == 1) button22.BackColor = button55.BackColor;
                                if (j == 2) button23.BackColor = button55.BackColor;
                                if (j == 3) button24.BackColor = button55.BackColor;
                                if (j == 4) button25.BackColor = button55.BackColor;
                                if (j == 5) button26.BackColor = button55.BackColor;
                                if (j == 6) button27.BackColor = button55.BackColor;
                                if (j == 7) button28.BackColor = button55.BackColor;
                            }
                            else
                                if (i == 5)
                                {
                                    if (j == 1) button29.BackColor = button55.BackColor;
                                    if (j == 2) button30.BackColor = button55.BackColor;
                                    if (j == 3) button31.BackColor = button55.BackColor;
                                    if (j == 4) button32.BackColor = button55.BackColor;
                                    if (j == 5) button33.BackColor = button55.BackColor;
                                    if (j == 6) button34.BackColor = button55.BackColor;
                                    if (j == 7) button35.BackColor = button55.BackColor;
                                }
                                else
                                    if (i == 6)
                                    {
                                        if (j == 1) button36.BackColor = button55.BackColor;
                                        if (j == 2) button37.BackColor = button55.BackColor;
                                        if (j == 3) button38.BackColor = button55.BackColor;
                                        if (j == 4) button39.BackColor = button55.BackColor;
                                        if (j == 5) button40.BackColor = button55.BackColor;
                                        if (j == 6) button41.BackColor = button55.BackColor;
                                        if (j == 7) button42.BackColor = button55.BackColor;
                                    }
                                    else
                                        if (i == 7)
                                        {
                                            if (j == 1) button43.BackColor = button55.BackColor;
                                            if (j == 2) button44.BackColor = button55.BackColor;
                                            if (j == 3) button45.BackColor = button55.BackColor;
                                            if (j == 4) button46.BackColor = button55.BackColor;
                                            if (j == 5) button47.BackColor = button55.BackColor;
                                            if (j == 6) button48.BackColor = button55.BackColor;
                                            if (j == 7) button49.BackColor = button55.BackColor;
                                        }
            }
            //////


            if (a[i, j] == 1)
            {
                if (i == 1)
                {
                    if (j == 1) button1.BackColor = button53.BackColor;
                    if (j == 2) button2.BackColor = button53.BackColor;
                    if (j == 3) button3.BackColor = button53.BackColor;
                    if (j == 4) button4.BackColor = button53.BackColor;
                    if (j == 5) button5.BackColor = button53.BackColor;
                    if (j == 6) button6.BackColor = button53.BackColor;
                    if (j == 7) button7.BackColor = button53.BackColor;
                }
                else
                    if (i == 2)
                    {
                        if (j == 1) button8.BackColor = button53.BackColor;
                        if (j == 2) button9.BackColor = button53.BackColor;
                        if (j == 3) button10.BackColor = button53.BackColor;
                        if (j == 4) button11.BackColor = button53.BackColor;
                        if (j == 5) button12.BackColor = button53.BackColor;
                        if (j == 6) button13.BackColor = button53.BackColor;
                        if (j == 7) button14.BackColor = button53.BackColor;
                    }
                    else
                        if (i == 3)
                        {
                            if (j == 1) button15.BackColor = button53.BackColor;
                            if (j == 2) button16.BackColor = button53.BackColor;
                            if (j == 3) button17.BackColor = button53.BackColor;
                            if (j == 4) button18.BackColor = button53.BackColor;
                            if (j == 5) button19.BackColor = button53.BackColor;
                            if (j == 6) button20.BackColor = button53.BackColor;
                            if (j == 7) button21.BackColor = button53.BackColor;
                        }
                        else
                            if (i == 4)
                            {
                                if (j == 1) button22.BackColor = button53.BackColor;
                                if (j == 2) button23.BackColor = button53.BackColor;
                                if (j == 3) button24.BackColor = button53.BackColor;
                                if (j == 4) button25.BackColor = button53.BackColor;
                                if (j == 5) button26.BackColor = button53.BackColor;
                                if (j == 6) button27.BackColor = button53.BackColor;
                                if (j == 7) button28.BackColor = button53.BackColor;
                            }
                            else
                                if (i == 5)
                                {
                                    if (j == 1) button29.BackColor = button53.BackColor;
                                    if (j == 2) button30.BackColor = button53.BackColor;
                                    if (j == 3) button31.BackColor = button53.BackColor;
                                    if (j == 4) button32.BackColor = button53.BackColor;
                                    if (j == 5) button33.BackColor = button53.BackColor;
                                    if (j == 6) button34.BackColor = button53.BackColor;
                                    if (j == 7) button35.BackColor = button53.BackColor;
                                }
                                else
                                    if (i == 6)
                                    {
                                        if (j == 1) button36.BackColor = button53.BackColor;
                                        if (j == 2) button37.BackColor = button53.BackColor;
                                        if (j == 3) button38.BackColor = button53.BackColor;
                                        if (j == 4) button39.BackColor = button53.BackColor;
                                        if (j == 5) button40.BackColor = button53.BackColor;
                                        if (j == 6) button41.BackColor = button53.BackColor;
                                        if (j == 7) button42.BackColor = button53.BackColor;
                                    }
                                    else
                                        if (i == 7)
                                        {
                                            if (j == 1) button43.BackColor = button53.BackColor;
                                            if (j == 2) button44.BackColor = button53.BackColor;
                                            if (j == 3) button45.BackColor = button53.BackColor;
                                            if (j == 4) button46.BackColor = button53.BackColor;
                                            if (j == 5) button47.BackColor = button53.BackColor;
                                            if (j == 6) button48.BackColor = button53.BackColor;
                                            if (j == 7) button49.BackColor = button53.BackColor;
                                        }
            }
            //////

            if (a[i, j] == 2)
            {
                if (i == 1)
                {
                    if (j == 1) button1.BackColor = button52.BackColor;
                    if (j == 2) button2.BackColor = button52.BackColor;
                    if (j == 3) button3.BackColor = button52.BackColor;
                    if (j == 4) button4.BackColor = button52.BackColor;
                    if (j == 5) button5.BackColor = button52.BackColor;
                    if (j == 6) button6.BackColor = button52.BackColor;
                    if (j == 7) button7.BackColor = button52.BackColor;
                }
                else
                    if (i == 2)
                    {
                        if (j == 1) button8.BackColor = button52.BackColor;
                        if (j == 2) button9.BackColor = button52.BackColor;
                        if (j == 3) button10.BackColor = button52.BackColor;
                        if (j == 4) button11.BackColor = button52.BackColor;
                        if (j == 5) button12.BackColor = button52.BackColor;
                        if (j == 6) button13.BackColor = button52.BackColor;
                        if (j == 7) button14.BackColor = button52.BackColor;
                    }
                    else
                        if (i == 3)
                        {
                            if (j == 1) button15.BackColor = button52.BackColor;
                            if (j == 2) button16.BackColor = button52.BackColor;
                            if (j == 3) button17.BackColor = button52.BackColor;
                            if (j == 4) button18.BackColor = button52.BackColor;
                            if (j == 5) button19.BackColor = button52.BackColor;
                            if (j == 6) button20.BackColor = button52.BackColor;
                            if (j == 7) button21.BackColor = button52.BackColor;
                        }
                        else
                            if (i == 4)
                            {
                                if (j == 1) button22.BackColor = button52.BackColor;
                                if (j == 2) button23.BackColor = button52.BackColor;
                                if (j == 3) button24.BackColor = button52.BackColor;
                                if (j == 4) button25.BackColor = button52.BackColor;
                                if (j == 5) button26.BackColor = button52.BackColor;
                                if (j == 6) button27.BackColor = button52.BackColor;
                                if (j == 7) button28.BackColor = button52.BackColor;
                            }
                            else
                                if (i == 5)
                                {
                                    if (j == 1) button29.BackColor = button52.BackColor;
                                    if (j == 2) button30.BackColor = button52.BackColor;
                                    if (j == 3) button31.BackColor = button52.BackColor;
                                    if (j == 4) button32.BackColor = button52.BackColor;
                                    if (j == 5) button33.BackColor = button52.BackColor;
                                    if (j == 6) button34.BackColor = button52.BackColor;
                                    if (j == 7) button35.BackColor = button52.BackColor;
                                }
                                else
                                    if (i == 6)
                                    {
                                        if (j == 1) button36.BackColor = button52.BackColor;
                                        if (j == 2) button37.BackColor = button52.BackColor;
                                        if (j == 3) button38.BackColor = button52.BackColor;
                                        if (j == 4) button39.BackColor = button52.BackColor;
                                        if (j == 5) button40.BackColor = button52.BackColor;
                                        if (j == 6) button41.BackColor = button52.BackColor;
                                        if (j == 7) button42.BackColor = button52.BackColor;
                                    }
                                    else
                                        if (i == 7)
                                        {
                                            if (j == 1) button43.BackColor = button52.BackColor;
                                            if (j == 2) button44.BackColor = button52.BackColor;
                                            if (j == 3) button45.BackColor = button52.BackColor;
                                            if (j == 4) button46.BackColor = button52.BackColor;
                                            if (j == 5) button47.BackColor = button52.BackColor;
                                            if (j == 6) button48.BackColor = button52.BackColor;
                                            if (j == 7) button49.BackColor = button52.BackColor;
                                        }
            }
            //////

            if (a[i, j] == 3)
            {
                if (i == 1)
                {
                    if (j == 1) button1.BackColor = button50.BackColor;
                    if (j == 2) button2.BackColor = button50.BackColor;
                    if (j == 3) button3.BackColor = button50.BackColor;
                    if (j == 4) button4.BackColor = button50.BackColor;
                    if (j == 5) button5.BackColor = button50.BackColor;
                    if (j == 6) button6.BackColor = button50.BackColor;
                    if (j == 7) button7.BackColor = button50.BackColor;
                }
                else
                    if (i == 2)
                    {
                        if (j == 1) button8.BackColor = button50.BackColor;
                        if (j == 2) button9.BackColor = button50.BackColor;
                        if (j == 3) button10.BackColor = button50.BackColor;
                        if (j == 4) button11.BackColor = button50.BackColor;
                        if (j == 5) button12.BackColor = button50.BackColor;
                        if (j == 6) button13.BackColor = button50.BackColor;
                        if (j == 7) button14.BackColor = button50.BackColor;
                    }
                    else
                        if (i == 3)
                        {
                            if (j == 1) button15.BackColor = button50.BackColor;
                            if (j == 2) button16.BackColor = button50.BackColor;
                            if (j == 3) button17.BackColor = button50.BackColor;
                            if (j == 4) button18.BackColor = button50.BackColor;
                            if (j == 5) button19.BackColor = button50.BackColor;
                            if (j == 6) button20.BackColor = button50.BackColor;
                            if (j == 7) button21.BackColor = button50.BackColor;
                        }
                        else
                            if (i == 4)
                            {
                                if (j == 1) button22.BackColor = button50.BackColor;
                                if (j == 2) button23.BackColor = button50.BackColor;
                                if (j == 3) button24.BackColor = button50.BackColor;
                                if (j == 4) button25.BackColor = button50.BackColor;
                                if (j == 5) button26.BackColor = button50.BackColor;
                                if (j == 6) button27.BackColor = button50.BackColor;
                                if (j == 7) button28.BackColor = button50.BackColor;
                            }
                            else
                                if (i == 5)
                                {
                                    if (j == 1) button29.BackColor = button50.BackColor;
                                    if (j == 2) button30.BackColor = button50.BackColor;
                                    if (j == 3) button31.BackColor = button50.BackColor;
                                    if (j == 4) button32.BackColor = button50.BackColor;
                                    if (j == 5) button33.BackColor = button50.BackColor;
                                    if (j == 6) button34.BackColor = button50.BackColor;
                                    if (j == 7) button35.BackColor = button50.BackColor;
                                }
                                else
                                    if (i == 6)
                                    {
                                        if (j == 1) button36.BackColor = button50.BackColor;
                                        if (j == 2) button37.BackColor = button50.BackColor;
                                        if (j == 3) button38.BackColor = button50.BackColor;
                                        if (j == 4) button39.BackColor = button50.BackColor;
                                        if (j == 5) button40.BackColor = button50.BackColor;
                                        if (j == 6) button41.BackColor = button50.BackColor;
                                        if (j == 7) button42.BackColor = button50.BackColor;
                                    }
                                    else
                                        if (i == 7)
                                        {
                                            if (j == 1) button43.BackColor = button50.BackColor;
                                            if (j == 2) button44.BackColor = button50.BackColor;
                                            if (j == 3) button45.BackColor = button50.BackColor;
                                            if (j == 4) button46.BackColor = button50.BackColor;
                                            if (j == 5) button47.BackColor = button50.BackColor;
                                            if (j == 6) button48.BackColor = button50.BackColor;
                                            if (j == 7) button49.BackColor = button50.BackColor;
                                        }
            }
            /////

            if (a[i, j] == 4)
            {
                if (i == 1)
                {
                    if (j == 1) button1.BackColor = button51.BackColor;
                    if (j == 2) button2.BackColor = button51.BackColor;
                    if (j == 3) button3.BackColor = button51.BackColor;
                    if (j == 4) button4.BackColor = button51.BackColor;
                    if (j == 5) button5.BackColor = button51.BackColor;
                    if (j == 6) button6.BackColor = button51.BackColor;
                    if (j == 7) button7.BackColor = button51.BackColor;
                }
                else
                    if (i == 2)
                    {
                        if (j == 1) button8.BackColor = button51.BackColor;
                        if (j == 2) button9.BackColor = button51.BackColor;
                        if (j == 3) button10.BackColor = button51.BackColor;
                        if (j == 4) button11.BackColor = button51.BackColor;
                        if (j == 5) button12.BackColor = button51.BackColor;
                        if (j == 6) button13.BackColor = button51.BackColor;
                        if (j == 7) button14.BackColor = button51.BackColor;
                    }
                    else
                        if (i == 3)
                        {
                            if (j == 1) button15.BackColor = button51.BackColor;
                            if (j == 2) button16.BackColor = button51.BackColor;
                            if (j == 3) button17.BackColor = button51.BackColor;
                            if (j == 4) button18.BackColor = button51.BackColor;
                            if (j == 5) button19.BackColor = button51.BackColor;
                            if (j == 6) button20.BackColor = button51.BackColor;
                            if (j == 7) button21.BackColor = button51.BackColor;
                        }
                        else
                            if (i == 4)
                            {
                                if (j == 1) button22.BackColor = button51.BackColor;
                                if (j == 2) button23.BackColor = button51.BackColor;
                                if (j == 3) button24.BackColor = button51.BackColor;
                                if (j == 4) button25.BackColor = button51.BackColor;
                                if (j == 5) button26.BackColor = button51.BackColor;
                                if (j == 6) button27.BackColor = button51.BackColor;
                                if (j == 7) button28.BackColor = button51.BackColor;
                            }
                            else
                                if (i == 5)
                                {
                                    if (j == 1) button29.BackColor = button51.BackColor;
                                    if (j == 2) button30.BackColor = button51.BackColor;
                                    if (j == 3) button31.BackColor = button51.BackColor;
                                    if (j == 4) button32.BackColor = button51.BackColor;
                                    if (j == 5) button33.BackColor = button51.BackColor;
                                    if (j == 6) button34.BackColor = button51.BackColor;
                                    if (j == 7) button35.BackColor = button51.BackColor;
                                }
                                else
                                    if (i == 6)
                                    {
                                        if (j == 1) button36.BackColor = button51.BackColor;
                                        if (j == 2) button37.BackColor = button51.BackColor;
                                        if (j == 3) button38.BackColor = button51.BackColor;
                                        if (j == 4) button39.BackColor = button51.BackColor;
                                        if (j == 5) button40.BackColor = button51.BackColor;
                                        if (j == 6) button41.BackColor = button51.BackColor;
                                        if (j == 7) button42.BackColor = button51.BackColor;
                                    }
                                    else
                                        if (i == 7)
                                        {
                                            if (j == 1) button43.BackColor = button51.BackColor;
                                            if (j == 2) button44.BackColor = button51.BackColor;
                                            if (j == 3) button45.BackColor = button51.BackColor;
                                            if (j == 4) button46.BackColor = button51.BackColor;
                                            if (j == 5) button47.BackColor = button51.BackColor;
                                            if (j == 6) button48.BackColor = button51.BackColor;
                                            if (j == 7) button49.BackColor = button51.BackColor;
                                        }
            }
        }
        private void coloreaza(int i,int j)
        { 
        if (a[i,j]== 5)
        {
            if (i == 1)
            {
                if (j == 1) button1.BackColor = rectangleShape2.BackColor;
                if (j == 2) button2.BackColor = rectangleShape2.BackColor;
                if (j == 3) button3.BackColor = rectangleShape2.BackColor;
                if (j == 4) button4.BackColor = rectangleShape2.BackColor;
                if (j == 5) button5.BackColor = rectangleShape2.BackColor;
                if (j == 6) button6.BackColor = rectangleShape2.BackColor;
                if (j == 7) button7.BackColor = rectangleShape2.BackColor;
            }
            else
                if (i == 2)
                {
                    if (j == 1) button8.BackColor = rectangleShape2.BackColor;
                    if (j == 2) button9.BackColor = rectangleShape2.BackColor;
                    if (j == 3) button10.BackColor = rectangleShape2.BackColor;
                    if (j == 4) button11.BackColor = rectangleShape2.BackColor;
                    if (j == 5) button12.BackColor = rectangleShape2.BackColor;
                    if (j == 6) button13.BackColor = rectangleShape2.BackColor;
                    if (j == 7) button14.BackColor = rectangleShape2.BackColor;
                }
                else
                    if (i == 3)
                    {
                        if (j == 1) button15.BackColor = rectangleShape2.BackColor;
                        if (j == 2) button16.BackColor = rectangleShape2.BackColor;
                        if (j == 3) button17.BackColor = rectangleShape2.BackColor;
                        if (j == 4) button18.BackColor = rectangleShape2.BackColor;
                        if (j == 5) button19.BackColor = rectangleShape2.BackColor;
                        if (j == 6) button20.BackColor = rectangleShape2.BackColor;
                        if (j == 7) button21.BackColor = rectangleShape2.BackColor;
                    }
                    else
                        if (i == 4)
                        {
                            if (j == 1) button22.BackColor = rectangleShape2.BackColor;
                            if (j == 2) button23.BackColor = rectangleShape2.BackColor;
                            if (j == 3) button24.BackColor = rectangleShape2.BackColor;
                            if (j == 4) button25.BackColor = rectangleShape2.BackColor;
                            if (j == 5) button26.BackColor = rectangleShape2.BackColor;
                            if (j == 6) button27.BackColor = rectangleShape2.BackColor;
                            if (j == 7) button28.BackColor = rectangleShape2.BackColor;
                        }
                        else
                            if (i == 5)
                            {
                                if (j == 1) button29.BackColor = rectangleShape2.BackColor;
                                if (j == 2) button30.BackColor = rectangleShape2.BackColor;
                                if (j == 3) button31.BackColor = rectangleShape2.BackColor;
                                if (j == 4) button32.BackColor = rectangleShape2.BackColor;
                                if (j == 5) button33.BackColor = rectangleShape2.BackColor;
                                if (j == 6) button34.BackColor = rectangleShape2.BackColor;
                                if (j == 7) button35.BackColor = rectangleShape2.BackColor;
                            }
                            else
                                if (i == 6)
                                {
                                    if (j == 1) button36.BackColor = rectangleShape2.BackColor;
                                    if (j == 2) button37.BackColor = rectangleShape2.BackColor;
                                    if (j == 3) button38.BackColor = rectangleShape2.BackColor;
                                    if (j == 4) button39.BackColor = rectangleShape2.BackColor;
                                    if (j == 5) button40.BackColor = rectangleShape2.BackColor;
                                    if (j == 6) button41.BackColor = rectangleShape2.BackColor;
                                    if (j == 7) button42.BackColor = rectangleShape2.BackColor;
                                }
                                else
                                    if (i == 7)
                                    {
                                        if (j == 1) button43.BackColor = rectangleShape2.BackColor;
                                        if (j == 2) button44.BackColor = rectangleShape2.BackColor;
                                        if (j == 3) button45.BackColor = rectangleShape2.BackColor;
                                        if (j == 4) button46.BackColor = rectangleShape2.BackColor;
                                        if (j == 5) button47.BackColor = rectangleShape2.BackColor;
                                        if (j == 6) button48.BackColor = rectangleShape2.BackColor;
                                        if (j == 7) button49.BackColor = rectangleShape2.BackColor;
                                    }
        }
            //////

        if (a[i, j] == 6)
        {
            if (i == 1)
            {
                if (j == 1) button1.BackColor = rectangleShape3.BackColor;
                if (j == 2) button2.BackColor = rectangleShape3.BackColor;
                if (j == 3) button3.BackColor = rectangleShape3.BackColor;
                if (j == 4) button4.BackColor = rectangleShape3.BackColor;
                if (j == 5) button5.BackColor = rectangleShape3.BackColor;
                if (j == 6) button6.BackColor = rectangleShape3.BackColor;
                if (j == 7) button7.BackColor = rectangleShape3.BackColor;
            }
            else
                if (i == 2)
                {
                    if (j == 1) button8.BackColor = rectangleShape3.BackColor;
                    if (j == 2) button9.BackColor = rectangleShape3.BackColor;
                    if (j == 3) button10.BackColor = rectangleShape3.BackColor;
                    if (j == 4) button11.BackColor = rectangleShape3.BackColor;
                    if (j == 5) button12.BackColor = rectangleShape3.BackColor;
                    if (j == 6) button13.BackColor = rectangleShape3.BackColor;
                    if (j == 7) button14.BackColor = rectangleShape3.BackColor;
                }
                else
                    if (i == 3)
                    {
                        if (j == 1) button15.BackColor = rectangleShape3.BackColor;
                        if (j == 2) button16.BackColor = rectangleShape3.BackColor;
                        if (j == 3) button17.BackColor = rectangleShape3.BackColor;
                        if (j == 4) button18.BackColor = rectangleShape3.BackColor;
                        if (j == 5) button19.BackColor = rectangleShape3.BackColor;
                        if (j == 6) button20.BackColor = rectangleShape3.BackColor;
                        if (j == 7) button21.BackColor = rectangleShape3.BackColor;
                    }
                    else
                        if (i == 4)
                        {
                            if (j == 1) button22.BackColor = rectangleShape3.BackColor;
                            if (j == 2) button23.BackColor = rectangleShape3.BackColor;
                            if (j == 3) button24.BackColor = rectangleShape3.BackColor;
                            if (j == 4) button25.BackColor = rectangleShape3.BackColor;
                            if (j == 5) button26.BackColor = rectangleShape3.BackColor;
                            if (j == 6) button27.BackColor = rectangleShape3.BackColor;
                            if (j == 7) button28.BackColor = rectangleShape3.BackColor;
                        }
                        else
                            if (i == 5)
                            {
                                if (j == 1) button29.BackColor = rectangleShape3.BackColor;
                                if (j == 2) button30.BackColor = rectangleShape3.BackColor;
                                if (j == 3) button31.BackColor = rectangleShape3.BackColor;
                                if (j == 4) button32.BackColor = rectangleShape3.BackColor;
                                if (j == 5) button33.BackColor = rectangleShape3.BackColor;
                                if (j == 6) button34.BackColor = rectangleShape3.BackColor;
                                if (j == 7) button35.BackColor = rectangleShape3.BackColor;
                            }
                            else
                                if (i == 6)
                                {
                                    if (j == 1) button36.BackColor = rectangleShape3.BackColor;
                                    if (j == 2) button37.BackColor = rectangleShape3.BackColor;
                                    if (j == 3) button38.BackColor = rectangleShape3.BackColor;
                                    if (j == 4) button39.BackColor = rectangleShape3.BackColor;
                                    if (j == 5) button40.BackColor = rectangleShape3.BackColor;
                                    if (j == 6) button41.BackColor = rectangleShape3.BackColor;
                                    if (j == 7) button42.BackColor = rectangleShape3.BackColor;
                                }
                                else
                                    if (i == 7)
                                    {
                                        if (j == 1) button43.BackColor = rectangleShape3.BackColor;
                                        if (j == 2) button44.BackColor = rectangleShape3.BackColor;
                                        if (j == 3) button45.BackColor = rectangleShape3.BackColor;
                                        if (j == 4) button46.BackColor = rectangleShape3.BackColor;
                                        if (j == 5) button47.BackColor = rectangleShape3.BackColor;
                                        if (j == 6) button48.BackColor = rectangleShape3.BackColor;
                                        if (j == 7) button49.BackColor = rectangleShape3.BackColor;
                                    }
        }
        //////

        if (a[i, j] == 7)
        {
            if (i == 1)
            {
                if (j == 1) button1.BackColor = rectangleShape4.BackColor;
                if (j == 2) button2.BackColor = rectangleShape4.BackColor;
                if (j == 3) button3.BackColor = rectangleShape4.BackColor;
                if (j == 4) button4.BackColor = rectangleShape4.BackColor;
                if (j == 5) button5.BackColor = rectangleShape4.BackColor;
                if (j == 6) button6.BackColor = rectangleShape4.BackColor;
                if (j == 7) button7.BackColor = rectangleShape4.BackColor;
            }
            else
                if (i == 2)
                {
                    if (j == 1) button8.BackColor = rectangleShape4.BackColor;
                    if (j == 2) button9.BackColor = rectangleShape4.BackColor;
                    if (j == 3) button10.BackColor = rectangleShape4.BackColor;
                    if (j == 4) button11.BackColor = rectangleShape4.BackColor;
                    if (j == 5) button12.BackColor = rectangleShape4.BackColor;
                    if (j == 6) button13.BackColor = rectangleShape4.BackColor;
                    if (j == 7) button14.BackColor = rectangleShape4.BackColor;
                }
                else
                    if (i == 3)
                    {
                        if (j == 1) button15.BackColor = rectangleShape4.BackColor;
                        if (j == 2) button16.BackColor = rectangleShape4.BackColor;
                        if (j == 3) button17.BackColor = rectangleShape4.BackColor;
                        if (j == 4) button18.BackColor = rectangleShape4.BackColor;
                        if (j == 5) button19.BackColor = rectangleShape4.BackColor;
                        if (j == 6) button20.BackColor = rectangleShape4.BackColor;
                        if (j == 7) button21.BackColor = rectangleShape4.BackColor;
                    }
                    else
                        if (i == 4)
                        {
                            if (j == 1) button22.BackColor = rectangleShape4.BackColor;
                            if (j == 2) button23.BackColor = rectangleShape4.BackColor;
                            if (j == 3) button24.BackColor = rectangleShape4.BackColor;
                            if (j == 4) button25.BackColor = rectangleShape4.BackColor;
                            if (j == 5) button26.BackColor = rectangleShape4.BackColor;
                            if (j == 6) button27.BackColor = rectangleShape4.BackColor;
                            if (j == 7) button28.BackColor = rectangleShape4.BackColor;
                        }
                        else
                            if (i == 5)
                            {
                                if (j == 1) button29.BackColor = rectangleShape4.BackColor;
                                if (j == 2) button30.BackColor = rectangleShape4.BackColor;
                                if (j == 3) button31.BackColor = rectangleShape4.BackColor;
                                if (j == 4) button32.BackColor = rectangleShape4.BackColor;
                                if (j == 5) button33.BackColor = rectangleShape4.BackColor;
                                if (j == 6) button34.BackColor = rectangleShape4.BackColor;
                                if (j == 7) button35.BackColor = rectangleShape4.BackColor;
                            }
                            else
                                if (i == 6)
                                {
                                    if (j == 1) button36.BackColor = rectangleShape4.BackColor;
                                    if (j == 2) button37.BackColor = rectangleShape4.BackColor;
                                    if (j == 3) button38.BackColor = rectangleShape4.BackColor;
                                    if (j == 4) button39.BackColor = rectangleShape4.BackColor;
                                    if (j == 5) button40.BackColor = rectangleShape4.BackColor;
                                    if (j == 6) button41.BackColor = rectangleShape4.BackColor;
                                    if (j == 7) button42.BackColor = rectangleShape4.BackColor;
                                }
                                else
                                    if (i == 7)
                                    {
                                        if (j == 1) button43.BackColor = rectangleShape4.BackColor;
                                        if (j == 2) button44.BackColor = rectangleShape4.BackColor;
                                        if (j == 3) button45.BackColor = rectangleShape4.BackColor;
                                        if (j == 4) button46.BackColor = rectangleShape4.BackColor;
                                        if (j == 5) button47.BackColor = rectangleShape4.BackColor;
                                        if (j == 6) button48.BackColor = rectangleShape4.BackColor;
                                        if (j == 7) button49.BackColor = rectangleShape4.BackColor;
                                    }
        }
        //////

        if (a[i, j] == 8)
        {
            if (i == 1)
            {
                if (j == 1) button1.BackColor = rectangleShape5.BackColor;
                if (j == 2) button2.BackColor = rectangleShape5.BackColor;
                if (j == 3) button3.BackColor = rectangleShape5.BackColor;
                if (j == 4) button4.BackColor = rectangleShape5.BackColor;
                if (j == 5) button5.BackColor = rectangleShape5.BackColor;
                if (j == 6) button6.BackColor = rectangleShape5.BackColor;
                if (j == 7) button7.BackColor = rectangleShape5.BackColor;
            }
            else
                if (i == 2)
                {
                    if (j == 1) button8.BackColor = rectangleShape5.BackColor;
                    if (j == 2) button9.BackColor = rectangleShape5.BackColor;
                    if (j == 3) button10.BackColor = rectangleShape5.BackColor;
                    if (j == 4) button11.BackColor = rectangleShape5.BackColor;
                    if (j == 5) button12.BackColor = rectangleShape5.BackColor;
                    if (j == 6) button13.BackColor = rectangleShape5.BackColor;
                    if (j == 7) button14.BackColor = rectangleShape5.BackColor;
                }
                else
                    if (i == 3)
                    {
                        if (j == 1) button15.BackColor = rectangleShape5.BackColor;
                        if (j == 2) button16.BackColor = rectangleShape5.BackColor;
                        if (j == 3) button17.BackColor = rectangleShape5.BackColor;
                        if (j == 4) button18.BackColor = rectangleShape5.BackColor;
                        if (j == 5) button19.BackColor = rectangleShape5.BackColor;
                        if (j == 6) button20.BackColor = rectangleShape5.BackColor;
                        if (j == 7) button21.BackColor = rectangleShape5.BackColor;
                    }
                    else
                        if (i == 4)
                        {
                            if (j == 1) button22.BackColor = rectangleShape5.BackColor;
                            if (j == 2) button23.BackColor = rectangleShape5.BackColor;
                            if (j == 3) button24.BackColor = rectangleShape5.BackColor;
                            if (j == 4) button25.BackColor = rectangleShape5.BackColor;
                            if (j == 5) button26.BackColor = rectangleShape5.BackColor;
                            if (j == 6) button27.BackColor = rectangleShape5.BackColor;
                            if (j == 7) button28.BackColor = rectangleShape5.BackColor;
                        }
                        else
                            if (i == 5)
                            {
                                if (j == 1) button29.BackColor = rectangleShape5.BackColor;
                                if (j == 2) button30.BackColor = rectangleShape5.BackColor;
                                if (j == 3) button31.BackColor = rectangleShape5.BackColor;
                                if (j == 4) button32.BackColor = rectangleShape5.BackColor;
                                if (j == 5) button33.BackColor = rectangleShape5.BackColor;
                                if (j == 6) button34.BackColor = rectangleShape5.BackColor;
                                if (j == 7) button35.BackColor = rectangleShape5.BackColor;
                            }
                            else
                                if (i == 6)
                                {
                                    if (j == 1) button36.BackColor = rectangleShape5.BackColor;
                                    if (j == 2) button37.BackColor = rectangleShape5.BackColor;
                                    if (j == 3) button38.BackColor = rectangleShape5.BackColor;
                                    if (j == 4) button39.BackColor = rectangleShape5.BackColor;
                                    if (j == 5) button40.BackColor = rectangleShape5.BackColor;
                                    if (j == 6) button41.BackColor = rectangleShape5.BackColor;
                                    if (j == 7) button42.BackColor = rectangleShape5.BackColor;
                                }
                                else
                                    if (i == 7)
                                    {
                                        if (j == 1) button43.BackColor = rectangleShape5.BackColor;
                                        if (j == 2) button44.BackColor = rectangleShape5.BackColor;
                                        if (j == 3) button45.BackColor = rectangleShape5.BackColor;
                                        if (j == 4) button46.BackColor = rectangleShape5.BackColor;
                                        if (j == 5) button47.BackColor = rectangleShape5.BackColor;
                                        if (j == 6) button48.BackColor = rectangleShape5.BackColor;
                                        if (j == 7) button49.BackColor = rectangleShape5.BackColor;
                                    }
        }

        }
        private void fill(int i, int j, int c)
        {
            a[i, j] = c;
            coloreaza(i, j);
            if (i-1>0&&a[i - 1, j] == c-4) fill( i - 1, j,c);//sus
            if(j+1<8&&a[i, j + 1] == c-4) fill( i, j + 1,c);//dreapta
            if (i+1<8&&a[i + 1, j] == c-4) fill( i + 1, j,c);//jos
            if (j - 1 > 0 && a[i, j - 1] == c-4) fill( i, j - 1,c);//stanga


        }
        private void parc()
        {
             ////creaza circuitul de culori
            int i; int j;
            for (i = 1; i < 8; i++)
            {
                for (j = 1; j < 8; j++)
                    if (a[i, j] > 4)  fill(i, j, culoare);  
                textbuton();
            }

        
        }
        private void singur()
         {

             if (culoare == 1)
             { culoare += 4; rectangleShape1.BackColor = rectangleShape2.BackColor; }
             if (culoare == 2)
             { culoare += 4; rectangleShape1.BackColor = rectangleShape3.BackColor; }
             if (culoare == 3)
             { culoare += 4; rectangleShape1.BackColor = rectangleShape4.BackColor; }
             if (culoare == 4)
             { culoare += 4; rectangleShape1.BackColor = rectangleShape5.BackColor; }

             parc();
         }
        private void Afisare4()
         {
             int i, j;
            Valid();
            if (validprod == 1)
            {
                for (i = 1; i <= n4; i++)
                {
                    if (x4[i] == 1) { culoare = 1; rectangleShape1.BackColor = rectangleShape2.BackColor; button56.BackColor = rectangleShape2.BackColor; singur(); }
                    if (x4[i] == 2) { culoare = 2; rectangleShape1.BackColor = rectangleShape3.BackColor; button56.BackColor = rectangleShape3.BackColor; singur(); }
                    if (x4[i] == 3) { culoare = 3; rectangleShape1.BackColor = rectangleShape4.BackColor; button56.BackColor = rectangleShape4.BackColor; singur(); }
                    if (x4[i] == 4) { culoare = 4; rectangleShape1.BackColor = rectangleShape5.BackColor; button56.BackColor = rectangleShape5.BackColor; singur(); }
                }
                verificare();
                if (sfarsit == 1) mata();
                else
                {
                    if (reusit == 0) { reusit = 1; for (i = 1; i <= n4; i++) { rezolvare[i] = x4[i]; textBox2.Text = textBox2.Text + x4[i]; } rezultatculori(); }
                }
            }
         }
        private  void BackRec4(int k)
         {
             if (reusit == 0)
             {
                 textBox2.Text = "open";
                 int i;
                 for (i = 1; i <= a2[k]; i++)
                 {
                     x4[k] = i;
                     if (k == n4) Afisare4();
                     else BackRec4(k + 1);
                 }
             }
           
         }
        private void coloreazasfera(int i, int c)
       {

           if (c == 0)
           {
               if (i == 1) ovalShape1.BackColor = button55.BackColor;
               if (i == 2) ovalShape2.BackColor = button55.BackColor;
               if (i == 3) ovalShape3.BackColor = button55.BackColor;
               if (i == 4) ovalShape4.BackColor = button55.BackColor;
               if (i == 5) ovalShape5.BackColor = button55.BackColor;
               if (i == 6) ovalShape6.BackColor = button55.BackColor;
               if (i == 7) ovalShape7.BackColor = button55.BackColor;
               if (i == 8) ovalShape8.BackColor = button55.BackColor;
               if (i == 9) ovalShape9.BackColor = button55.BackColor;
               if (i == 10) ovalShape10.BackColor = button55.BackColor;
               if (i == 11) ovalShape11.BackColor = button55.BackColor;
               if (i == 12) ovalShape12.BackColor = button55.BackColor;
               if (i == 13) ovalShape13.BackColor = button55.BackColor;
               if (i == 14) ovalShape14.BackColor = button55.BackColor;
               if (i == 15) ovalShape15.BackColor = button55.BackColor;
               if (i == 16) ovalShape16.BackColor = button55.BackColor;
           }
           if (c == 1)
           {
               if (i == 1) ovalShape1.BackColor = button53.BackColor;
               if (i == 2) ovalShape2.BackColor = button53.BackColor;
               if (i == 3) ovalShape3.BackColor = button53.BackColor;
               if (i == 4) ovalShape4.BackColor = button53.BackColor;
               if (i == 5) ovalShape5.BackColor = button53.BackColor;
               if (i == 6) ovalShape6.BackColor = button53.BackColor;
               if (i == 7) ovalShape7.BackColor = button53.BackColor;
               if (i == 8) ovalShape8.BackColor = button53.BackColor;
               if (i == 9) ovalShape9.BackColor = button53.BackColor;
               if (i == 10) ovalShape10.BackColor = button53.BackColor;
               if (i == 11) ovalShape11.BackColor = button53.BackColor;
               if (i == 12) ovalShape12.BackColor = button53.BackColor;
               if (i == 13) ovalShape13.BackColor = button53.BackColor;
               if (i == 14) ovalShape14.BackColor = button53.BackColor;
               if (i == 15) ovalShape15.BackColor = button53.BackColor;
               if (i == 16) ovalShape16.BackColor = button53.BackColor;
           }
           if (c == 2)
           {
               if (i == 1) ovalShape1.BackColor = button52.BackColor;
               if (i == 2) ovalShape2.BackColor = button52.BackColor;
               if (i == 3) ovalShape3.BackColor = button52.BackColor;
               if (i == 4) ovalShape4.BackColor = button52.BackColor;
               if (i == 5) ovalShape5.BackColor = button52.BackColor;
               if (i == 6) ovalShape6.BackColor = button52.BackColor;
               if (i == 7) ovalShape7.BackColor = button52.BackColor;
               if (i == 8) ovalShape8.BackColor = button52.BackColor;
               if (i == 9) ovalShape9.BackColor = button52.BackColor;
               if (i == 10) ovalShape10.BackColor = button52.BackColor;
               if (i == 11) ovalShape11.BackColor = button52.BackColor;
               if (i == 12) ovalShape12.BackColor = button52.BackColor;
               if (i == 13) ovalShape13.BackColor = button52.BackColor;
               if (i == 14) ovalShape14.BackColor = button52.BackColor;
               if (i == 15) ovalShape15.BackColor = button52.BackColor;
               if (i == 16) ovalShape16.BackColor = button52.BackColor;
           }
           if (c == 3)
           {
               if (i == 1) ovalShape1.BackColor = button50.BackColor;
               if (i == 2) ovalShape2.BackColor = button50.BackColor;
               if (i == 3) ovalShape3.BackColor = button50.BackColor;
               if (i == 4) ovalShape4.BackColor = button50.BackColor;
               if (i == 5) ovalShape5.BackColor = button50.BackColor;
               if (i == 6) ovalShape6.BackColor = button50.BackColor;
               if (i == 7) ovalShape7.BackColor = button50.BackColor;
               if (i == 8) ovalShape8.BackColor = button50.BackColor;
               if (i == 9) ovalShape9.BackColor = button50.BackColor;
               if (i == 10) ovalShape10.BackColor = button50.BackColor;
               if (i == 11) ovalShape11.BackColor = button50.BackColor;
               if (i == 12) ovalShape12.BackColor = button50.BackColor;
               if (i == 13) ovalShape13.BackColor = button50.BackColor;
               if (i == 14) ovalShape14.BackColor = button50.BackColor;
               if (i == 15) ovalShape15.BackColor = button50.BackColor;
               if (i == 16) ovalShape16.BackColor = button50.BackColor;
           }
           if (c == 4)
           {
               if (i == 1) ovalShape1.BackColor = button51.BackColor;
               if (i == 2) ovalShape2.BackColor = button51.BackColor;
               if (i == 3) ovalShape3.BackColor = button51.BackColor;
               if (i == 4) ovalShape4.BackColor = button51.BackColor;
               if (i == 5) ovalShape5.BackColor = button51.BackColor;
               if (i == 6) ovalShape6.BackColor = button51.BackColor;
               if (i == 7) ovalShape7.BackColor = button51.BackColor;
               if (i == 8) ovalShape8.BackColor = button51.BackColor;
               if (i == 9) ovalShape9.BackColor = button51.BackColor;
               if (i == 10) ovalShape10.BackColor = button51.BackColor;
               if (i == 11) ovalShape11.BackColor = button51.BackColor;
               if (i == 12) ovalShape12.BackColor = button51.BackColor;
               if (i == 13) ovalShape13.BackColor = button51.BackColor;
               if (i == 14) ovalShape14.BackColor = button51.BackColor;
               if (i == 15) ovalShape15.BackColor = button51.BackColor;
               if (i == 16) ovalShape16.BackColor = button51.BackColor;
           }
       }
        private void rezultatculori()
       {

           for (int i = 1; i <= n4; i++)
               coloreazasfera(i, rezolvare[i]);
       }

         private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            culoare = 2;
            rectangleShape1.BackColor = button52.BackColor;
            button56.BackColor = button52.BackColor;
            button59.BackColor = button52.BackColor;
            button60.BackColor = button52.BackColor;
            button61.BackColor = button52.BackColor;
            button62.BackColor = button52.BackColor;
            button63.BackColor = button52.BackColor;
            button64.BackColor = button52.BackColor;
            button65.BackColor = button52.BackColor;

            button66.BackColor = button52.BackColor;
            button67.BackColor = button52.BackColor;
            button68.BackColor = button52.BackColor;
            button69.BackColor = button52.BackColor;
            button70.BackColor = button52.BackColor;
            button71.BackColor = button52.BackColor;
            button72.BackColor = button52.BackColor;

            button73.BackColor = button52.BackColor;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            culoare = 4;
            rectangleShape1.BackColor = button51.BackColor;
            button56.BackColor = button51.BackColor;
            button59.BackColor = button51.BackColor;
            button60.BackColor = button51.BackColor;
            button61.BackColor = button51.BackColor;
            button62.BackColor = button51.BackColor;
            button63.BackColor = button51.BackColor;
            button64.BackColor = button51.BackColor;
            button65.BackColor = button51.BackColor;

            button66.BackColor = button51.BackColor;
            button67.BackColor = button51.BackColor;
            button68.BackColor = button51.BackColor;
            button69.BackColor = button51.BackColor;
            button70.BackColor = button51.BackColor;
            button71.BackColor = button51.BackColor;
            button72.BackColor = button51.BackColor;

            button73.BackColor = button51.BackColor;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            culoare = 3;
            rectangleShape1.BackColor = button50.BackColor;
            button56.BackColor = button50.BackColor;
            button59.BackColor = button50.BackColor;
            button60.BackColor = button50.BackColor;
            button61.BackColor = button50.BackColor;
            button62.BackColor = button50.BackColor;
            button63.BackColor = button50.BackColor;
            button64.BackColor = button50.BackColor;
            button65.BackColor = button50.BackColor;

            button66.BackColor = button50.BackColor;
            button67.BackColor = button50.BackColor;
            button68.BackColor = button50.BackColor;
            button69.BackColor = button50.BackColor;
            button70.BackColor = button50.BackColor;
            button71.BackColor = button50.BackColor;
            button72.BackColor = button50.BackColor;

            button73.BackColor = button50.BackColor;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            culoare = 1;
            rectangleShape1.BackColor = button53.BackColor;
            button56.BackColor = button53.BackColor;

            button59.BackColor = button53.BackColor;
            button60.BackColor = button53.BackColor;
            button61.BackColor = button53.BackColor;
            button62.BackColor = button53.BackColor;
            button63.BackColor = button53.BackColor;
            button64.BackColor = button53.BackColor;
            button65.BackColor = button53.BackColor;

            button66.BackColor = button53.BackColor;
            button67.BackColor = button53.BackColor;
            button68.BackColor = button53.BackColor;
            button69.BackColor = button53.BackColor;
            button70.BackColor = button53.BackColor;
            button71.BackColor = button53.BackColor;
            button72.BackColor = button53.BackColor;

            button73.BackColor = button53.BackColor;
        }

        private void button54_Click(object sender, EventArgs e)//////inceput
        {
            if (culoare == 1)
            { culoare += 4; rectangleShape1.BackColor = rectangleShape2.BackColor; }
            if (culoare == 2)
               { culoare += 4;   rectangleShape1.BackColor = rectangleShape3.BackColor;}
            if (culoare == 3)
              { culoare += 4;    rectangleShape1.BackColor = rectangleShape4.BackColor;}
            if (culoare == 4)
            { culoare += 4; rectangleShape1.BackColor = rectangleShape5.BackColor; }
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a[1, 1] = culoare;
            button1.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a[1, 2] = culoare;
            button2.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a[1, 3] = culoare;
            button3.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a[1, 4] = culoare;
            button4.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a[1, 5] = culoare;
            button5.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a[1, 6] = culoare;
            button6.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a[1, 7] = culoare;
            button7.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a[2, 1] = culoare;
            button8.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a[2, 4] = culoare;
            button11.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a[2, 3] = culoare;
            button10.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a[2, 2] = culoare;
            button9.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a[2, 5] = culoare;
            button12.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a[2, 6] = culoare;
            button13.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a[2, 7] = culoare;
            button14.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a[3,1 ] = culoare;
            button15.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button16_Click(object sender, EventArgs e)
        {
             a[3,2 ] = culoare;
            button16.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button17_Click(object sender, EventArgs e)
        {
             a[3, 3] = culoare;
            button17.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button18_Click(object sender, EventArgs e)
        {
             a[3,4 ] = culoare;
            button18.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button19_Click(object sender, EventArgs e)
        {
             a[3, 5] = culoare;
            button19.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button20_Click(object sender, EventArgs e)
        {
             a[3, 6] = culoare;
            button20.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button21_Click(object sender, EventArgs e)
        {
             a[3, 7] = culoare;
            button21.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button22_Click(object sender, EventArgs e)
        {
             a[4,1 ] = culoare;
            button22.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a[4, 2] = culoare;
            button23.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a[4, 3] = culoare;
            button24.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a[4, 4] = culoare;
            button25.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a[4, 5] = culoare;
            button26.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a[4, 6] = culoare;
            button27.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            a[4, 7] = culoare;
            button28.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            a[5, 1] = culoare;
            button29.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button30_Click(object sender, EventArgs e)
        {
             a[5,2 ] = culoare;
            button30.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button31_Click(object sender, EventArgs e)
        {
             a[5,3 ] = culoare;
            button31.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button32_Click(object sender, EventArgs e)
        {
             a[5,4 ] = culoare;
            button32.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button33_Click(object sender, EventArgs e)
        {
             a[5, 5] = culoare;
            button33.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button34_Click(object sender, EventArgs e)
        {
             a[5,6 ] = culoare;
            button34.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button35_Click(object sender, EventArgs e)
        {
             a[5,7 ] = culoare;
            button35.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button36_Click(object sender, EventArgs e)
        {
             a[6, 1] = culoare;
            button36.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            a[6, 2] = culoare;
            button37.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            a[6,3 ] = culoare;
            button38.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            a[6,4 ] = culoare;
            button39.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            a[6,5 ] = culoare;
            button40.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            a[6, 6] = culoare;
            button41.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            a[6,7 ] = culoare;
            button42.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            a[7,1 ] = culoare;
            button43.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button44_Click(object sender, EventArgs e)
        {
             a[7,2 ] = culoare;
            button44.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button45_Click(object sender, EventArgs e)
        {
             a[7,3 ] = culoare;
            button45.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button46_Click(object sender, EventArgs e)
        {
             a[7, 4] = culoare;
            button46.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button47_Click(object sender, EventArgs e)
        {
             a[7, 5] = culoare;
            button47.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button48_Click(object sender, EventArgs e)
        {
             a[7, 6] = culoare;
            button48.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button49_Click(object sender, EventArgs e)
        {
             a[7,7 ] = culoare;
            button49.BackColor = rectangleShape1.BackColor;
            textbuton();
        }

        private void button55_Click(object sender, EventArgs e) ////start
        {
            
            culinceput = culoare-4;
          
            n4 =  int.Parse(textBox1.Text);
          
            parc();
            matb();
        }

        private void button56_Click(object sender, EventArgs e)/////singur
        {

            culinceput = culoare - 4;

            n4 = int.Parse(textBox1.Text);

            parc();
            matb();

            BackRec4(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.BackColor = button57.BackColor;
            singur();
        }

        private void vezisolutie(int i)
        {
            if (i <= n4)
            {
                if (rezolvare[i] == 1) { culoare = 1; rectangleShape1.BackColor = rectangleShape2.BackColor; button56.BackColor = rectangleShape2.BackColor; singur(); }
                if (rezolvare[i] == 2) { culoare = 2; rectangleShape1.BackColor = rectangleShape3.BackColor; button56.BackColor = rectangleShape3.BackColor; singur(); }
                if (rezolvare[i] == 3) { culoare = 3; rectangleShape1.BackColor = rectangleShape4.BackColor; button56.BackColor = rectangleShape4.BackColor; singur(); }
                if (rezolvare[i] == 4) { culoare = 4; rectangleShape1.BackColor = rectangleShape5.BackColor; button56.BackColor = rectangleShape5.BackColor; singur(); }
                i++;
            }
            else timer1.Stop();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            aux++;
            vezisolutie(aux);

        }

        private void button58_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 17; i++)
                coloreazasfera(i, 0);
            textBox2.Text = "";
            reusit = 0;
         
            for (int i = 1; i < 8; i++)
                for (int j = 1; j < 8; j++)
                { a[i, j] = 0; coloreaza2(i, j); }
            textbuton();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (a[3, 1] == 0)
            {
                a[3, 1] = culoare;
                button15.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 2] == 0)
            {
                a[3, 2] = culoare;
                button16.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 3] == 0)
            {
                a[3, 3] = culoare;
                button17.BackColor = rectangleShape1.BackColor;
            }


            if (a[3, 4] == 0)
            {
                a[3, 4] = culoare;
                button18.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 5] == 0)
            {
                a[3, 5] = culoare;
                button19.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 6] == 0)
            {
                a[3, 6] = culoare;
                button20.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 7] == 0)
            {
                a[3, 7] = culoare;
                button21.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (a[1, 1] == 0)
            {
                a[1, 1] = culoare;
                button1.BackColor = rectangleShape1.BackColor;
            }

            if (a[1, 2] == 0)
            {
                a[1, 2] = culoare;
                button2.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 3] == 0)
            {
                a[1, 3] = culoare;
                button3.BackColor = rectangleShape1.BackColor;
            }

            if (a[1, 4] == 0)
            {
                a[1, 4] = culoare;
                button4.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 5] == 0)
            {
                a[1, 5] = culoare;
                button5.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 6] == 0)
            {
                a[1, 6] = culoare;
                button6.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 7] == 0)
            {
                a[1, 7] = culoare;
                button7.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (a[2, 1] == 0)
            {
                a[2, 1] = culoare;
                button8.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 2] == 0)
            {
                a[2, 2] = culoare;
                button9.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 3] == 0)
            {
                a[2, 3] = culoare;
                button10.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 4] == 0)
            {
                a[2, 4] = culoare;
                button11.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 5] == 0)
            {
                a[2, 5] = culoare;
                button12.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 6] == 0)
            {
                a[2, 6] = culoare;
                button13.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 7] == 0)
            {
                a[2, 7] = culoare;
                button14.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button62_Click(object sender, EventArgs e)
        {

            if (a[4, 1] == 0)
            {
                a[4, 1] = culoare;
                button22.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 2] == 0)
            {
                a[4, 2] = culoare;
                button23.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 3] == 0)
            {
                a[4, 3] = culoare;
                button24.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 4] == 0)
            {
                a[4, 4] = culoare;
                button25.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 5] == 0)
            {
                a[4, 5] = culoare;
                button26.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 6] == 0)
            {
                a[4, 6] = culoare;
                button27.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 7] == 0)
            {
                a[4, 7] = culoare;
                button28.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (a[5, 1] == 0)
            {
                a[5, 1] = culoare;
                button29.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 2] == 0)
            {
                a[5, 2] = culoare;
                button30.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 3] == 0)
            {
                a[5, 3] = culoare;
                button31.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 4] == 0)
            {
                a[5, 4] = culoare;
                button32.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 5] == 0)
            {
                a[5, 5] = culoare;
                button33.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 6] == 0)
            {
                a[5, 6] = culoare;
                button34.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 7] == 0)
            {
                a[5, 7] = culoare;
                button35.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (a[6, 1] == 0)
            {
                a[6, 1] = culoare;
                button36.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 2] == 0)
            {
                a[6, 2] = culoare;
                button37.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 3] == 0)
            {
                a[6, 3] = culoare;
                button38.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 4] == 0)
            {

                a[6, 4] = culoare;
                button39.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 5] == 0)
            {
                a[6, 5] = culoare;
                button40.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 6] == 0)
            {
                a[6, 6] = culoare;
                button41.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 7] == 0)
            {
                a[6, 7] = culoare;
                button42.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (a[7, 1] == 0)
            {
                a[7, 1] = culoare;
                button43.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 2] == 0)
            {
                a[7, 2] = culoare;
                button44.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 3] == 0)
            {
                a[7, 3] = culoare;
                button45.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 4] == 0)
            {
                a[7, 4] = culoare;
                button46.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 5] == 0)
            {
                a[7, 5] = culoare;
                button47.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 6] == 0)
            {
                a[7, 6] = culoare;
                button48.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 7] == 0)
            {
                a[7, 7] = culoare;
                button49.BackColor = rectangleShape1.BackColor;
            }

            textbuton();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (a[1, 1] == 0)
            {
                a[1, 1] = culoare;
                button1.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 1] == 0)
            {
                a[2, 1] = culoare;
                button8.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 1] == 0)
            {
                a[3, 1] = culoare;
                button15.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 1] == 0)
            {
                a[4, 1] = culoare;
                button22.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 1] == 0)
            {
                a[5, 1] = culoare;
                button29.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 1] == 0)
            {
                a[6, 1] = culoare;
                button36.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 1] == 0)
            {
                a[7, 1] = culoare;
                button43.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (a[1, 5] == 0)
            {
                a[1, 5] = culoare;
                button5.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 5] == 0)
            {
                a[2, 5] = culoare;
                button12.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 5] == 0)
            {
                a[3, 5] = culoare;
                button19.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 5] == 0)
            {
                a[4, 5] = culoare;
                button26.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 5] == 0)
            {
                a[5, 5] = culoare;
                button33.BackColor = rectangleShape1.BackColor;
            }

            if (a[6, 5] == 0)
            {
                a[6, 5] = culoare;
                button40.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 5] == 0)
            {
                a[7, 5] = culoare;
                button47.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (a[1, 6] == 0)
            {
                a[1, 6] = culoare;
                button6.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 6] == 0)
            {
                a[2, 6] = culoare;
                button13.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 6] == 0)
            {
                a[3, 6] = culoare;
                button20.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 6] == 0)
            {
                a[4, 6] = culoare;
                button27.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 6] == 0)
            {
                a[5, 6] = culoare;
                button34.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 6] == 0)
            {
                a[6, 6] = culoare;
                button41.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 6] == 0)
            {
                a[7, 6] = culoare;
                button48.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (a[1, 2] == 0)
            {
                a[1, 2] = culoare;
                button2.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 2] == 0)
            {
                a[2, 2] = culoare;
                button9.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 2] == 0)
            {
                a[3, 2] = culoare;
                button16.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 2] == 0)
            {
                a[4, 2] = culoare;
                button23.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 2] == 0)
            {
                a[5, 2] = culoare;
                button30.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 2] == 0)
            {
                a[6, 2] = culoare;
                button37.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 2] == 0)
            {
                a[7, 2] = culoare;
                button44.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (a[1, 3] == 0)
            {
                a[1, 3] = culoare;
                button3.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 3] == 0)
            {
                a[2, 3] = culoare;
                button10.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 3] == 0)
            {
                a[3, 3] = culoare;
                button17.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 3] == 0)
            {
                a[4, 3] = culoare;
                button24.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 3] == 0)
            {
                a[5, 3] = culoare;
                button31.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 3] == 0)
            {
                a[6, 3] = culoare;
                button38.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 3] == 0)
            {

                a[7, 3] = culoare;
                button45.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (a[1, 4] == 0)
            {
                a[1, 4] = culoare;
                button4.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 4] == 0)
            {
                a[2, 4] = culoare;
                button11.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 4] == 0)
            {
                a[3, 4] = culoare;
                button18.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 4] == 0)
            {
                a[4, 4] = culoare;
                button25.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 4] == 0)
            {
                a[5, 4] = culoare;
                button32.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 4] == 0)
            {
                a[6, 4] = culoare;
                button39.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 4] == 0)
            {
                a[7, 4] = culoare;
                button46.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (a[1, 7] == 0)
            {
                a[1, 7] = culoare;
                button7.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 7] == 0)
            {
                a[2, 7] = culoare;
                button14.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 7] == 0)
            {
                a[3, 7] = culoare;
                button21.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 7] == 0)
            {
                a[4, 7] = culoare;
                button28.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 7] == 0)
            {
                a[5, 7] = culoare;
                button35.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 7] == 0)
            {
                a[6, 7] = culoare;
                button42.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 7] == 0)
            {
                a[7, 7] = culoare;
                button49.BackColor = rectangleShape1.BackColor;
            }
            textbuton();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (a[1, 1] == 0)
            {
                a[1, 1] = culoare;
                button1.BackColor = rectangleShape1.BackColor;
            }

            if (a[1, 2] == 0)
            {
                a[1, 2] = culoare;
                button2.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 3] == 0)
            {
                a[1, 3] = culoare;
                button3.BackColor = rectangleShape1.BackColor;
            }

            if (a[1, 4] == 0)
            {
                a[1, 4] = culoare;
                button4.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 5] == 0)
            {
                a[1, 5] = culoare;
                button5.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 6] == 0)
            {
                a[1, 6] = culoare;
                button6.BackColor = rectangleShape1.BackColor;
            }
            if (a[1, 7] == 0)
            {
                a[1, 7] = culoare;
                button7.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 1] == 0)
            {
                a[2, 1] = culoare;
                button8.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 2] == 0)
            {
                a[2, 2] = culoare;
                button9.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 3] == 0)
            {
                a[2, 3] = culoare;
                button10.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 4] == 0)
            {
                a[2, 4] = culoare;
                button11.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 5] == 0)
            {
                a[2, 5] = culoare;
                button12.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 6] == 0)
            {
                a[2, 6] = culoare;
                button13.BackColor = rectangleShape1.BackColor;
            }
            if (a[2, 7] == 0)
            {
                a[2, 7] = culoare;
                button14.BackColor = rectangleShape1.BackColor;
            }
            if (a[3, 1] == 0)
            {
                a[3, 1] = culoare;
                button15.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 2] == 0)
            {
                a[3, 2] = culoare;
                button16.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 3] == 0)
            {
                a[3, 3] = culoare;
                button17.BackColor = rectangleShape1.BackColor;
            }


            if (a[3, 4] == 0)
            {
                a[3, 4] = culoare;
                button18.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 5] == 0)
            {
                a[3, 5] = culoare;
                button19.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 6] == 0)
            {
                a[3, 6] = culoare;
                button20.BackColor = rectangleShape1.BackColor;
            }

            if (a[3, 7] == 0)
            {
                a[3, 7] = culoare;
                button21.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 1] == 0)
            {
                a[4, 1] = culoare;
                button22.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 2] == 0)
            {
                a[4, 2] = culoare;
                button23.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 3] == 0)
            {
                a[4, 3] = culoare;
                button24.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 4] == 0)
            {
                a[4, 4] = culoare;
                button25.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 5] == 0)
            {
                a[4, 5] = culoare;
                button26.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 6] == 0)
            {
                a[4, 6] = culoare;
                button27.BackColor = rectangleShape1.BackColor;
            }
            if (a[4, 7] == 0)
            {
                a[4, 7] = culoare;
                button28.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 1] == 0)
            {
                a[5, 1] = culoare;
                button29.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 2] == 0)
            {
                a[5, 2] = culoare;
                button30.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 3] == 0)
            {
                a[5, 3] = culoare;
                button31.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 4] == 0)
            {
                a[5, 4] = culoare;
                button32.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 5] == 0)
            {
                a[5, 5] = culoare;
                button33.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 6] == 0)
            {
                a[5, 6] = culoare;
                button34.BackColor = rectangleShape1.BackColor;
            }
            if (a[5, 7] == 0)
            {
                a[5, 7] = culoare;
                button35.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 1] == 0)
            {
                a[6, 1] = culoare;
                button36.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 2] == 0)
            {
                a[6, 2] = culoare;
                button37.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 3] == 0)
            {
                a[6, 3] = culoare;
                button38.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 4] == 0)
            {

                a[6, 4] = culoare;
                button39.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 5] == 0)
            {
                a[6, 5] = culoare;
                button40.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 6] == 0)
            {
                a[6, 6] = culoare;
                button41.BackColor = rectangleShape1.BackColor;
            }
            if (a[6, 7] == 0)
            {
                a[6, 7] = culoare;
                button42.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 1] == 0)
            {
                a[7, 1] = culoare;
                button43.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 2] == 0)
            {
                a[7, 2] = culoare;
                button44.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 3] == 0)
            {
                a[7, 3] = culoare;
                button45.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 4] == 0)
            {
                a[7, 4] = culoare;
                button46.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 5] == 0)
            {
                a[7, 5] = culoare;
                button47.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 6] == 0)
            {
                a[7, 6] = culoare;
                button48.BackColor = rectangleShape1.BackColor;
            }
            if (a[7, 7] == 0)
            {
                a[7, 7] = culoare;
                button49.BackColor = rectangleShape1.BackColor;
            }

            textbuton();

        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 5;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 6;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 7;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" +8;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 9;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + 10;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            aux = 0;
            
            reusit = 0;
            mata();
          
            for (int i = 1; i < 8; i++)
                for (int j = 1; j < 8; j++)
                coloreaza2(i, j); 
            textbuton();
            timer1.Start();
        }
    }
}
