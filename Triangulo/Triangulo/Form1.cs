namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {

            double ladoB=0, ladoA=0, ladoC=0;




            if (!double.TryParse(txtA.Text, out  ladoA))
                MessageBox.Show("Lado A inv�lido");
            else if (!double.TryParse(txtB.Text, out  ladoB ))
                MessageBox.Show("Lado B inv�lido");
            else if (!double.TryParse(txtC.Text, out  ladoC ))
                MessageBox.Show("Lado C inv�lido");

            if (ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC) && ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC) && ladoC < (ladoB + ladoA) && ladoC > Math.Abs(ladoA - ladoB))
                {
                    if ((ladoA==ladoB) && (ladoB==ladoC))
                        MessageBox.Show("� um equil�tero");
                    else if (( ladoA!=ladoB) && (ladoB!=ladoC) && (ladoA!=ladoC))
                        MessageBox.Show("� um escaleno");
                    else
                        MessageBox.Show("� um is�celes");

                }
            else
                    MessageBox.Show("Lados n�o formam um triangulo");









            




        }
    }
}