using p.a_estacionamento.objeto;

namespace p.a_estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();
            vaga vg = new vaga();
            vg.status =checkBox1.Text;
            vg.horario = dateTimePicker1.Value;
            vg.numero = Convert.ToInt32(textBox4.Text);
            if (vg.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            numero.Value = dataGridView1.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            status.Text = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
            data.Value = dataGridView1.Rows[e.RowIndex].Cells["data"].Value.ToString();
    
            if (pago == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
        }
    }
}
