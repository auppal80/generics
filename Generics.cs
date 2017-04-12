using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
    public partial class Generics : Form
    {
        public Generics()
        {
            InitializeComponent();
        }

        private void btnTestGenericsExample_Click(object sender, EventArgs e)
        {
            Operation<int, int, int> operationInt = new Operation<int, int, int>();
            int result = operationInt.extract(5, 3);
            MessageBox.Show(result.ToString());

            Operation<Double, Double, Double> operationDecimal= new Operation<Double, Double, Double>();
            Double resultDecimal = operationDecimal.extract(5.5, 3.4);
            MessageBox.Show(resultDecimal.ToString());

        }
    }
}
