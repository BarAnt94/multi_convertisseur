namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetSelectedMode(string[] mode)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(mode);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(mode);
        }
        private void Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] signs_temperature = { "°C", "°F", "°K" };
            string[] sign_money = { "€", "$" };
            string[] sign_speed = { "Km", "Miles" };
            string[] sign_mass = { "Kg", "lbs" };
            if (Mode.SelectedItem.ToString() == "Température")
                GetSelectedMode(signs_temperature);
            else if (Mode.SelectedItem.ToString() == "Monnaie")
                GetSelectedMode(sign_money);
            else if (Mode.SelectedItem.ToString() == "Vitesse")
                GetSelectedMode(sign_speed);
            else if (Mode.SelectedItem.ToString() == "Masse")
                GetSelectedMode(sign_mass);
        }
        private bool Units_Selected()
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner les unités de départ et de résultat.", 
                    "Erreur de sélection", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private static void ShowFormatError()
        {
            MessageBox.Show(
                "Veuillez entrer une valeur numérique valide pour la température.",
                "Erreur de format",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private static decimal ConvertTemperature(decimal temperature, string startUnit, string resultUnit)
        {
            if (startUnit == "°C" && resultUnit == "°F")
                return (temperature * 9 / 5) + 32;
            else if (startUnit == "°C" && resultUnit == "°K")
                return temperature + 273.15m;
            else if (startUnit == "°F" && resultUnit == "°C")
                return (temperature - 32) * 5 / 9;
            else if (startUnit == "°F" && resultUnit == "°K")
                return (((temperature - 32) * 5 / 9) + 273.15m);
            else if (startUnit == "°K" && resultUnit == "°C")
                return temperature - 273.15m;
            else if (startUnit == "°K" && resultUnit == "°F")
                return (((temperature - 273.15m) * 9 / 5) + 32);
            else if (startUnit == resultUnit)
                return temperature;
            return 0;
        }
        private static decimal ConvertSpeed(decimal speed, string startUnit, string resultUnit)
        {
            if (startUnit == "Km" && resultUnit == "Miles")
                return speed * 0.621371m;
            else if (startUnit == "Miles" && resultUnit == "Km")
                return speed / 0.621371m;
            else if (startUnit == resultUnit)
                return speed;
            return 0;
        }
        private static decimal ConvertMass(decimal mass, string startUnit, string resultUnit)
        {
            if (startUnit == "Kg" && resultUnit == "lbs")
                return mass * 2.20462m;
            else if (startUnit == "lbs" && resultUnit == "Kg")
                return mass / 2.20462m;
            else if (startUnit == resultUnit)
                return mass;
            return 0;
        }
        private static decimal ConvertMoney(decimal amount, string startUnit, string resultUnit)
        {
            if (startUnit == "€" && resultUnit == "$")
                return (amount * 1) / 0.86m;
            else if (startUnit == "$" && resultUnit == "€")
                return (amount * 0.86m) / 1;
            else if (startUnit == resultUnit)
                return amount;
            return 0;
        }
        public void Temperature_Conversion(object sender, EventArgs e)
        {
            if(!Units_Selected())
                return;
            if (!decimal.TryParse(txt_value.Text, out decimal temperature))
            {
                ShowFormatError();
                return;
            }
            string startUnit = comboBox1.Text;
            string resultUnit = comboBox2.Text;
            decimal result = ConvertTemperature(temperature, startUnit, resultUnit);
            lbl_result.Text = $"Résultat: {result} {resultUnit}";

        }

        public void Money_Conversion(object sender, EventArgs e)
        {
            if (!Units_Selected())
                return;

            if (!decimal.TryParse(txt_value.Text, out decimal money))
            {
                ShowFormatError();
                return;
            }
            string startUnit = comboBox1.Text;
            string resultUnit = comboBox2.Text;
            decimal result = ConvertMoney(money, startUnit, resultUnit);
            lbl_result.Text = $"Résultat: {result} {resultUnit}";
        }
        public void Speed_Conversion(object sender, EventArgs e)
        {
           if(!Units_Selected())
               return;

           if (!decimal.TryParse(txt_value.Text, out decimal speed))
           {
               ShowFormatError();
               return;
           }
            string startUnit = comboBox1.Text;
            string resultUnit = comboBox2.Text;
            decimal result = ConvertSpeed(speed, startUnit, resultUnit);
            lbl_result.Text = $"Résultat: {result.ToString()} {resultUnit}";
        }
        public void Mass_Conversion(object sender, EventArgs e)
        {
            if(!Units_Selected()) 
                return;

            if (!decimal.TryParse(txt_value.Text, out decimal mass))
            {
                ShowFormatError();
                return;
            }
            string startUnit = comboBox1.Text;
            string resultUnit = comboBox2.Text;
            decimal result = ConvertMass(mass, startUnit, resultUnit);
            lbl_result.Text = $"Résultat: {result} {resultUnit}";
        }

        private void Convertion_Click(object sender, EventArgs e)
        {
            if(Mode.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un mode de conversion.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (Mode.SelectedItem.ToString())
            {
                case "Température":
                    Temperature_Conversion(sender, e);
                    break;
                case "Monnaie":
                    Money_Conversion(sender, e);
                    break;
                case "Vitesse":
                    Speed_Conversion(sender, e);
                    break;
                case "Masse":
                    Mass_Conversion(sender, e);
                    break;
            }
        }
    }
}