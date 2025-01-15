using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Collections.Specialized;
using Microsoft.Win32;

namespace JocDeTable
{
    public partial class Form1 : Form
    {
        internal Piesa[] player1()
        {
            Piesa[] piese = new Piesa[15];

            piese[0] = new Piesa(1, 790, 25, new Rectangle(), Brushes.Yellow);
            piese[1] = new Piesa(1, 790, 60, new Rectangle(), Brushes.Yellow);

            piese[2] = new Piesa(12, 80, 25, new Rectangle(), Brushes.Yellow);
            piese[3] = new Piesa(12, 80, 60, new Rectangle(), Brushes.Yellow);
            piese[4] = new Piesa(12, 80, 95, new Rectangle(), Brushes.Yellow);
            piese[5] = new Piesa(12, 80, 130, new Rectangle(), Brushes.Yellow);
            piese[6] = new Piesa(12, 80, 165, new Rectangle(), Brushes.Yellow);


            piese[7] = new Piesa(17, 324, 500, new Rectangle(), Brushes.Yellow);
            piese[8] = new Piesa(17, 324, 465, new Rectangle(), Brushes.Yellow);
            piese[9] = new Piesa(17, 324, 430, new Rectangle(), Brushes.Yellow);

            piese[10] = new Piesa(19, 485, 500, new Rectangle(), Brushes.Yellow);
            piese[11] = new Piesa(19, 485, 465, new Rectangle(), Brushes.Yellow);
            piese[12] = new Piesa(19, 485, 430, new Rectangle(), Brushes.Yellow);
            piese[13] = new Piesa(19, 485, 395, new Rectangle(), Brushes.Yellow);
            piese[14] = new Piesa(19, 485, 360, new Rectangle(), Brushes.Yellow);
            return piese;
        }
        internal  Piesa[] player2()
        {
            Piesa[] piese = new Piesa[15];
            piese[13] = new Piesa(24, 790, 500, new Rectangle(), Brushes.Green);
            piese[14] = new Piesa(24, 790, 465, new Rectangle(), Brushes.Green);

            piese[8] = new Piesa(13, 80, 500, new Rectangle(), Brushes.Green);
            piese[9] = new Piesa(13, 80, 465, new Rectangle(), Brushes.Green);
            piese[10] = new Piesa(13, 80, 430, new Rectangle(), Brushes.Green);
            piese[11] = new Piesa(13, 80, 395, new Rectangle(), Brushes.Green);
            piese[12] = new Piesa(13, 80, 360, new Rectangle(), Brushes.Green);


            piese[5] = new Piesa(8, 324, 25, new Rectangle(), Brushes.Green);
            piese[6] = new Piesa(8, 324, 60, new Rectangle(), Brushes.Green);
            piese[7] = new Piesa(8, 324, 95, new Rectangle(), Brushes.Green);

            piese[0] = new Piesa(6, 485, 25, new Rectangle(), Brushes.Green);
            piese[1] = new Piesa(6, 485, 60, new Rectangle(), Brushes.Green);
            piese[2] = new Piesa(6, 485, 95, new Rectangle(), Brushes.Green);
            piese[3] = new Piesa(6, 485, 130, new Rectangle(), Brushes.Green);
            piese[4] = new Piesa(6, 485, 165, new Rectangle(), Brushes.Green);
            return piese;
        }
       
        Piesa[] piese;
        Piesa[] juc2;
        
        internal  int[] posibil()
        {
            int[] v = new int[25];
            for (int i = 1; i <=24; i++)
            {
                for (int j = 0; j < piese.Length; j++)
                {
                    if (i == piese[j].getLoc())
                        v[i]++;
                }
                for(int k=0;k<juc2.Length;k++)
                {
                    if (i == juc2[k].getLoc())
                        v[i]++;
                }
            }
            return v;
        }

       
        
         internal  int PiesaCorecta(Piesa verificata)
        {
            int corect=1;
            for (int i = 0; i < piese.Length; i++)
            {
                if (piese[i].getLoc() == verificata.getLoc() && piese[i].getY1() > verificata.getY1())
                {
                    if (verificata.getLoc() <= 12)
                    {
                        corect = 0;
                    }
                }
                if (piese[i].getLoc() == verificata.getLoc() && piese[i].getY1() < verificata.getY1())
                {
                    if (verificata.getLoc() > 12)
                    {

                        corect = 0;
                    }

                }
            }
            for (int i = 0; i < juc2.Length; i++)
            {

                if (juc2[i].getLoc() == verificata.getLoc() && juc2[i].getY1() > verificata.getY1())
                    {
                    if (verificata.getLoc() <= 12)
                    {
                        corect = 0;
                    }
                    }
               
              
                    if (juc2[i].getLoc() == verificata.getLoc() && juc2[i].getY1() < verificata.getY1())
                    {
                    if (verificata.getLoc() > 12)
                    {
                        corect = 0;
                    }
                    }
               
            }
            return corect;
        }

        internal int[] ColOcP2()
        {
            int[] v = new int[25];
            for (int i = 1; i <= 24; i++)
            {
                for (int k = 0; k < juc2.Length; k++)
                {
                    if (i == juc2[k].getLoc())
                        v[i]++;
                }

            }
            return v;
        }
        internal int[] ColOcP1()
        {
            int[] v = new int[25];
            for (int i = 1; i <= 24; i++)
            {
                for (int j = 0; j < piese.Length; j++)
                {
                    if (i == piese[j].getLoc())
                        v[i]++;
                }

            }
            return v;
        }
        public Form1()
        {
            InitializeComponent();
            
             piese = player1();
             juc2 = player2();
        }
        int contur = 15;
        internal int CasaGalbenaOK()
        {
            int ok = 0;
            int c=0;
            for (int j = 0; j < piese.Length; j++)
            {
                if (piese[j].getLoc() >= 19)
                { c++; }
            }
            if(c==contur)
            {
                ok = 1;
            }
            return ok;
        }
        internal int verificarePLayer1()
        {
            int ok = 0;
            int c=0;
         
                for (int j = 0; j < piese.Length; j++)
                {
                if (piese[j].getLoc() == 0)
                    c++;
                }
                if(c==15)
            {
                ok = 1;
            }
            return ok;

        }
        int contur1 = 15;
        internal int CasaVerdeOK()
        {
            int ok = 0;
            int c = 0;
            for (int j = 0; j < juc2.Length; j++)
            {
                if (juc2[j].getLoc() <= 6 && (juc2[j].getLoc()!=0))
                { c++; }
            }
            if (c == contur1)
            {
                ok = 1;
            }
            return ok;
        }
        internal int verificarePLayer2()
        {
            int ok = 0;
            int c = 0;

            for (int j = 0; j < juc2.Length; j++)
            {
                if (juc2[j].getLoc() == 0)
                    c++;
            }
            if (c == 15)
            {
                ok = 1;
            }
            return ok;

        }
        internal int verificarepiesaCapturata(Piesa capturata,int tip)
        {
            int ok = 0;
            int VeriY1=25;
            int VerifY2=500;
            if (tip == 2)
            {
                for (int j=0;j<juc2.Length;j++)
                {
                    if (juc2[j].getLoc()==0 && juc2[j].getY1()<VerifY2)
                    {
                        VerifY2 = juc2[j].getY1();
                    }
                }
            }
            if (tip == 1)
            {
                for (int j = 0; j < juc2.Length; j++)
                {
                    if (piese[j].getLoc() == 0 && piese[j].getY1() > VeriY1)
                    {
                        VeriY1= piese[j].getY1();
                    }
                }
            }
            if(capturata.getY1()==VerifY2 && tip==2)
            {
                ok = 1;
            }
            if(capturata.getY1()==VeriY1 && tip==1)
                {
                ok = 1;
            }
            
            return ok;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            for (int i = 0; i < piese.Length; i++)
            {
                e.Graphics.FillEllipse(piese[i].getCuloare(), piese[i].getForma());
            }
            for (int i = 0; i < juc2.Length; i++)
            {
                e.Graphics.FillEllipse(juc2[i].getCuloare(), juc2[i].getForma());
            }
        }
        int ycapturare1 = 25;
        int ycapturare2 = 500;
        int castigator;
        int numarmutari;
        int ok=0;
        int capturategalben = 0;
        int capturateverde = 0;
            private void Mutare(object sender, MouseEventArgs e)
        {
            int[] coloane = posibil();
            int[] coloane1 = ColOcP1();
            int[] coloane2 = ColOcP2();
            if (castigator == 0)
            {


                if ((nrcount - valzar) >= 0  && numarmutari != 0 && ok == 0 && CasaGalbenaOK() == 0 && capturategalben==0)
                {
                    for (int j = 0; j < piese.Length; j++)
                    {
                        if (piese[j].getForma().Contains(e.Location) && PiesaCorecta(piese[j]) == 1 && ( piese[j].getLoc() + numarmutari) <= 23 && (coloane2[piese[j].getLoc() + numarmutari] ==0))

                            {
                                piese[j].mutariPlayer1(numarmutari, coloane[piese[j].getLoc() + numarmutari]);
                                numarmutari = 0;

                                nrcount = nrcount - valzar;
                                Refresh();
                            
                        }
                        if (piese[j].getForma().Contains(e.Location) && PiesaCorecta(piese[j]) == 1 && (piese[j].getLoc() + numarmutari) == 24 && (coloane2[piese[j].getLoc() + numarmutari] ==0))
                            {
                                piese[j].mutariPlayer1(numarmutari, coloane[24]);
                                numarmutari = 0;
                                nrcount = nrcount - valzar;
                                Refresh();
                            
                        }

                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 1;
                        nrcount = 2;
                        blocat = 0;
                    }

                }




                if ((nrcount - valzar) >= 0 &&  numarmutari != 0 && ok == 0 && CasaGalbenaOK() == 0 && capturategalben == 0)
                {
                    for (int j = 0; j < piese.Length; j++)
                    {
                        if (piese[j].getForma().Contains(e.Location) && PiesaCorecta(piese[j]) == 1 && (piese[j].getLoc() + numarmutari) <= 23 && (coloane2[piese[j].getLoc() + numarmutari] == 1))
                            {
                                
                                    for (int w = 0; w < juc2.Length; w++)
                                    {
                                        if (juc2[w].getLoc() == piese[j].getLoc() + numarmutari)
                                        {
                                            
                                            juc2[w].setLoc(0);
                                            juc2[w].setX(435);
                                            juc2[w].setY(ycapturare2);
                                            ycapturare2 -= 35;
                                            capturateverde++;
                                        break;
                                        }
                                    }
                                
                                piese[j].mutariPlayer1(numarmutari, 0);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                            
                        }
                        if (piese[j].getForma().Contains(e.Location) && PiesaCorecta(piese[j]) == 1 && (piese[j].getLoc() + numarmutari) == 24 && (coloane2[piese[j].getLoc() + numarmutari] == 1))
                            {
                                
                                    for (int w = 0; w < juc2.Length; w++)
                                    {
                                        if (juc2[w].getLoc() == piese[j].getLoc() + numarmutari)
                                        {
                                          
                                            juc2[w].setLoc(0);
                                            juc2[w].setX(435);
                                            juc2[w].setY(ycapturare2);
                                            ycapturare2-=35;
                                            capturateverde++;
                                      
                                        }
                                    }
                                
                                piese[j].mutariPlayer1(numarmutari, 0);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                            
                        }

                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 1;
                        nrcount = 2;
                        blocat = 0;
                    }

                }


                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 0 && CasaGalbenaOK() == 0 && capturategalben != 0)
                {

                    for (int z = 0; z < piese.Length; z++)
                    {
                        if (piese[z].getX1() == 435 && piese[z].getForma().Contains(e.Location) && verificarepiesaCapturata(piese[z], 1) == 1 && numarmutari<=6 && coloane2[piese[z].getLoc() + numarmutari] <1)
                            {
                                piese[z].setLoc(numarmutari);
                                int a = 61 * numarmutari;
                                piese[z].setX(851 - a);
                                piese[z].setY(25 + 35 * coloane[piese[z].getLoc()]);
                                capturategalben--;
                                numarmutari = 0; nrcount = nrcount - valzar;                               
                                Refresh();
                                ycapturare1 -= 35;
                        }
                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 1;
                        nrcount = 2;
                        blocat = 0;
                    }
                }
                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 0 && CasaGalbenaOK() == 0 && capturategalben != 0)
                {

                    for (int z = 0; z < piese.Length; z++)
                    {
                        if (piese[z].getX1() == 435 && piese[z].getForma().Contains(e.Location) && verificarepiesaCapturata(piese[z], 1) == 1 && numarmutari <= 6 && coloane2[piese[z].getLoc() + numarmutari] ==1)
                            {
                                for (int w = 0; w < juc2.Length; w++)
                                {
                                    if (juc2[w].getLoc() == piese[z].getLoc() + numarmutari)
                                    {
                                        piese[z].setLoc(piese[z].getLoc()+numarmutari);
                                        piese[z].setX(851-61*numarmutari);
                                        piese[z].setY(25);
                                        juc2[w].setLoc(0);
                                        juc2[w].setX(435);
                                        juc2[w].setY(ycapturare2);
                                        capturategalben--;
                                        ycapturare1 -= 35;
                                        ycapturare2 -= 35;
                                        capturateverde++;
                                        Refresh();
                                        numarmutari = 0; nrcount = nrcount - valzar;
                                        break;
                                    }
                                }
                            }
                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 1;
                        nrcount = 2;
                        blocat = 0;
                    }
                }



                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 0 && CasaGalbenaOK() == 1 && capturategalben == 0)
                {
                    for (int j = 0; j < piese.Length; j++)
                    {
                        if (piese[j].getForma().Contains(e.Location) && piese[j].getLoc()+numarmutari>=25 && PiesaCorecta(piese[j]) == 1)
                        {
                            piese[j].setLoc(0);
                            piese[j].setX(100);
                            piese[j].setY(1000);
                            numarmutari = 0; nrcount = nrcount - valzar;
                            Refresh();
                            contur--;
                        }
                        if (piese[j].getForma().Contains(e.Location) && piese[j].getLoc() + numarmutari < 25 && PiesaCorecta(piese[j]) == 1)
                        {
                            piese[j].mutariPlayer1(numarmutari, coloane[piese[j].getLoc() + numarmutari]);
                            Refresh();
                            numarmutari = 0; nrcount = nrcount - valzar;
                        }
                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 1;
                        nrcount = 2;
                        blocat = 0;
                    }
                }







                    if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 1 && CasaVerdeOK() == 0 && capturateverde==0)
                {

                    for (int z = 0; z < juc2.Length; z++)
                    {

                        if (juc2[z].getForma().Contains(e.Location) && PiesaCorecta(juc2[z]) == 1 && (juc2[z].getLoc() - numarmutari) < coloane.Length && (juc2[z].getLoc() - numarmutari) > 1 && (coloane1[juc2[z].getLoc() - numarmutari] ==0))
                        { 
                                juc2[z].mutariPlayer2(numarmutari, coloane[juc2[z].getLoc() - numarmutari]);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                            
                        }
                        if (juc2[z].getForma().Contains(e.Location) && PiesaCorecta(juc2[z]) == 1 && (juc2[z].getLoc() - numarmutari) == 1 && (coloane1[juc2[z].getLoc() - numarmutari] ==0))
                         {
                                juc2[z].mutariPlayer2(numarmutari, coloane[1]);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                            
                        }

                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 0;
                        nrcount = 2;
                        blocat = 0;
                    }
                }



                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 1 && CasaVerdeOK() == 0 && capturateverde==0)
                {
                    for (int j = 0; j < juc2.Length; j++)
                    {
                        if (juc2[j].getForma().Contains(e.Location) && PiesaCorecta(juc2[j]) == 1 && (juc2[j].getLoc() - numarmutari) < coloane.Length && (juc2[j].getLoc() - numarmutari) > 1 && (coloane1[juc2[j].getLoc() - numarmutari] == 1))
                        {
                            for (int w = 0; w < piese.Length; w++)
                                {
                                    if (piese[w].getLoc() == juc2[j].getLoc() - numarmutari)
                                    {

                                        piese[w].setLoc(0);
                                        piese[w].setX(435);
                                        piese[w].setY(ycapturare1);
                                        ycapturare1 += 35;
                                        capturategalben++;
                                        break;
                                    }
                                }

                                juc2[j].mutariPlayer2(numarmutari, 0);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                        }
                        if (juc2[j].getForma().Contains(e.Location) && PiesaCorecta(juc2[j]) == 1 && (juc2[j].getLoc() - numarmutari) == 1 && (coloane1[juc2[j].getLoc() - numarmutari] == 1))
                        {
                                for (int w = 0; w < piese.Length; w++)
                                {
                                    if (piese[w].getLoc() == juc2[j].getLoc() - numarmutari)
                                    {

                                        piese[w].setLoc(0);
                                        piese[w].setX(435);
                                        piese[w].setY(ycapturare1);
                                        ycapturare1 += 35;
                                        capturategalben++;
                                        break;
                                    }
                                }

                                juc2[j].mutariPlayer2(numarmutari, 0);
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                            
                        }

                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 0;
                        nrcount = 2;
                        blocat = 0;
                    }

                }


                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 1 && CasaVerdeOK() == 1 && capturateverde==0)
                {
                    for (int z = 0; z < juc2.Length; z++)
                    {
                        if (juc2[z].getForma().Contains(e.Location) && numarmutari >= juc2[z].getLoc() && PiesaCorecta(juc2[z]) == 1)
                        {
                            juc2[z].setLoc(0);
                            juc2[z].setX(100);
                            juc2[z].setY(1000);
                            numarmutari = 0; nrcount = nrcount - valzar;
                            Refresh();
                            contur1--;
                        }
                        if (juc2[z].getForma().Contains(e.Location) && (juc2[z].getLoc()> numarmutari)  && PiesaCorecta(juc2[z]) == 1)
                        {
                            juc2[z].mutariPlayer2(numarmutari, coloane[juc2[z].getLoc() - numarmutari]);
                            Refresh();
                            numarmutari = 0; nrcount = nrcount - valzar;
                        }
                    }

                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 0;
                        nrcount = 2;
                        blocat = 0;
                    }
                }






                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 1 && CasaVerdeOK() == 0 && capturateverde != 0)
                {

                    for (int z = 0; z < juc2.Length; z++)
                    {
                        if (juc2[z].getX1() == 435 && juc2[z].getForma().Contains(e.Location) && verificarepiesaCapturata(juc2[z], 2) == 1 && coloane1[25 - numarmutari] < 1 && numarmutari<=6)
                        {
                                juc2[z].setLoc(25-numarmutari);
                                int a = 61 * numarmutari;
                                juc2[z].setX(851 - a);
                                juc2[z].setY(500 - 35 * coloane[juc2[z].getLoc()]);
                                capturateverde--;
                                numarmutari = 0; nrcount = nrcount - valzar;
                                Refresh();
                                ycapturare2 += 35;
                        }
                    }
                    if (numarmutari == 0 && nrcount == 0)
                    {
                        prevcount = count;
                        ok = 0;
                        nrcount = 2;
                        blocat = 0;
                    }
                }

                if ((nrcount - valzar) >= 0 && numarmutari != 0 && ok == 1 && CasaVerdeOK() == 0 && capturateverde != 0)
                {

                    for (int z = 0; z < juc2.Length; z++)
                    {
                        if (juc2[z].getX1() == 435 && juc2[z].getForma().Contains(e.Location) && verificarepiesaCapturata(juc2[z], 2) == 1 && coloane1[25 - numarmutari] == 1)
                        {
                                for (int w = 0; w < piese.Length; w++)
                                {
                                    if (piese[w].getLoc() == 25 - numarmutari)
                                    {
                                        juc2[z].setLoc(25 - numarmutari);
                                        juc2[z].setX(851-61*numarmutari);
                                        juc2[z].setY(500);
                                        piese[w].setLoc(0);
                                        piese[w].setX(435);
                                        piese[w].setY(ycapturare1);
                                        ycapturare1 += 35;
                                        ycapturare2 += 35;
                                        capturategalben++;
                                        capturateverde--;
                                        numarmutari = 0; nrcount = nrcount - valzar;
                                        Refresh();
                                        break;
                                    }
                                }
                        }
                    }
                    if (numarmutari == 0 && nrcount==0)
                    {
                        prevcount = count;
                        ok = 0;
                        nrcount = 2;
                        blocat = 0;
                    }
                }
                if (verificarePLayer1() == 1)
                {
                    MessageBox.Show("Yellow WINS");
                    castigator = 1;
                }
                if (verificarePLayer2() == 1)
                {
                    MessageBox.Show("Green WINS");
                    castigator=1;
                }
                if (ok == 1)
                {
                    button5.Text = "Jucator curent : 2(verde)";
                }
                if (ok == 0)
                {

                    button5.Text = "Jucator curent : 1(galben)";
                }
            }
        }

        int valzar;
        Random rnd = new Random();
        int nrcount = 2;
        int blocat;
        int pornit = 0;
        int count =0, prevcount=0;
        private void Zar_Click(object sender, EventArgs e)
        {
            count++;
            pornit++;
            int num,num1;
            
                num = rnd.Next(1, 7);
                num1 = rnd.Next(1, 7);
            if (blocat == 0)
            {
                button1.Text = num.ToString();
                button2.Text = num1.ToString();
                button3.Text = (num + num1).ToString();
                blocat = 1;
            }
            String mesaj ="Zar";
            Zar.Text = mesaj;
            String mesaj1 = "Termina tura galben";
            String mesaj2 = "Termina tura verde";
            button4.Text = mesaj1;
            button6.Text = mesaj2;
            if (ok == 1)
            {
                button5.Text = "Jucator curent : 2(verde)";
            }
            if (ok == 0)
            {

                button5.Text = "Jucator curent : 1(galben)";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (pornit != 0 && count!=prevcount)
            {
                numarmutari = Convert.ToInt32(button1.Text);
                valzar = 1;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pornit != 0 && count != prevcount)
            {
                numarmutari = Convert.ToInt32(button2.Text);
                valzar = 1;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pornit != 0 && count != prevcount)
            {
                if (nrcount == 2)
                {
                    numarmutari = Convert.ToInt32(button3.Text);
                    valzar = 2;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if(ok==0)
            {
                blocat = 0;
                nrcount = 2;
                ok = 1;
                MessageBox.Show("Mutare terminata jucator 1(galben)");
                button5.Text = "Jucator curent : 2(verde)";
                prevcount = count;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                blocat = 0;
                nrcount = 2;
                ok = 0;
                MessageBox.Show("Mutare terminata jucator 2(verde)");
                button5.Text = "Jucator curent : 1(galben)";
                prevcount = count;
            }
        }
    }
}
