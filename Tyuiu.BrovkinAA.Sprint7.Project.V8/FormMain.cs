using System.Windows.Forms;
using Tyuiu.BrovkinAA.Sprint7.Project.V8.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BrovkinAA.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            toolStripMenuSaveItem.Enabled = false;
        }

        public static DataService ds = new DataService();
        public bool hasChanged = false;
        public string loadedFile;
        public bool dataIsLoading = false;
        public bool addingNewString = false;

        public List<List<string>> dataEmployee = ds.StringToListTranslate(ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "EmployeeData.csv")));
        public List<List<string>> dataCars = ds.StringToListTranslate(ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "CarsData.csv")));
        public List<List<string>> dataDelivery = ds.StringToListTranslate(ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "DeliveryData.csv")));

        public void FromFileToGrid(List<List<string>> data, string[] headers)
        {
            this.toolStripMenuActionsItem.Enabled = false;

            this.dataGridViewLoadData.DataSource = null;
            this.dataGridViewLoadData.Rows.Clear();

            this.dataGridViewLoadData.RowCount = data.Count;
            this.dataGridViewLoadData.ColumnCount = data[0].Count;

            for (int i = 0; i < headers.Length; i++)
            {
                this.dataGridViewLoadData.Columns[i].HeaderText = headers[i];
                this.dataGridViewLoadData.Columns[i].Width = 100;
            }
            this.dataGridViewLoadData.Columns[0].Width = 150;

            for (int i = 0; i < data.Count; i++)
            {
                this.dataGridViewLoadData.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            this.dataGridViewLoadData.RowHeadersWidth = 75;

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[0].Count; j++)
                {
                    this.dataGridViewLoadData.Rows[i].Cells[j].Value = data[i][j].ToString();
                }
            }

            dataIsLoading = true;
        }

        private void toolStripMenuEmployeeInfoItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataIsLoading = false;
                loadedFile = "EmployeeData.csv";
                string[] headers = { "Табельный номер водител", "Фамилия", "Имя", "Отчество", "Дата рождения", "Стаж работы", "Оклад" };

                FromFileToGrid(dataEmployee, headers);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuCarsInfoItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataIsLoading = false;
                loadedFile = "CarsData.csv";
                string[] headers = { "Номерной знак автомобиля", "Марка автомобиля", "Техническое состояние", "Местонахождение автомобиля", "Средняя скорость", "Грузоподъёмность", "Расход топлива" };

                FromFileToGrid(dataCars, headers);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuDeliveryInfoItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataIsLoading = false;
                loadedFile = "DeliveryData.csv";
                string[] headers = { "Дата выезда", "Дата прибытия", "Место назначения", "Расстояние", "Масса груза" };

                FromFileToGrid(dataDelivery, headers);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowMoreInfoAbout(int rowIndex)
        {

            string[,] keyEmpCars = ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "EmpCars.csv"));
            string[,] keyEmpDeliv = ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "EmpDeliv.csv"));
            string[,] keyCarsDeliv = ds.LoadDataFromFile(Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "CarsDeliv.csv"));
            string[] headersCars = { "Номерной знак автомобиля", "Марка автомобиля", "Техническое состояние", "Местонахождение автомобиля", "Средняя скорость", "Грузоподъёмность", "Расход топлива" };
            string[] headersDelivery = { "Дата выезда", "Дата прибытия", "Место назначения", "Расстояние", "Масса груза" };
            string[] headersEmployee = { "Табельный номер водител", "Фамилия", "Имя", "Отчество", "Дата рождения", "Стаж работы", "Оклад" };

            if (loadedFile == "EmployeeData.csv")
            {
                string keyEmp = dataGridViewLoadData.Rows[rowIndex].Cells[0].Value.ToString();

                List<string> keys = new List<string>();
                for (int i = 0; i < keyEmpCars.GetLength(0); i++)
                {
                    if (keyEmpCars[i, 0] == keyEmp)
                    {
                        keys.Add(keyEmpCars[i, 1]);
                    }
                }
                List<List<string>> data = dataCars;
                ShowInfoToDataGrid(dataGridViewDataLeft, data, headersCars, keys);

                keys.Clear();

                for (int i = 0; i < keyEmpDeliv.GetLength(0); i++)
                {
                    if (keyEmpDeliv[i, 0] == keyEmp)
                    {
                        keys.Add(keyEmpDeliv[i, 1]);
                    }
                }
                data = dataDelivery;
                ShowInfoToDataGrid(dataGridViewDataRight, data, headersDelivery, keys);
            }
            else if (loadedFile == "CarsData.csv")
            {
                string keyCar = dataGridViewLoadData.Rows[rowIndex].Cells[0].Value.ToString();

                List<string> keys = new List<string>();
                for (int i = 0; i < keyEmpCars.GetLength(0); i++)
                {
                    if (keyEmpCars[i, 1] == keyCar)
                    {
                        keys.Add(keyEmpCars[i, 0]);
                    }
                }
                List<List<string>> data = dataEmployee;
                ShowInfoToDataGrid(dataGridViewDataLeft, data, headersEmployee, keys);

                keys.Clear();

                for (int i = 0; i < keyCarsDeliv.GetLength(0); i++)
                {
                    if (keyCarsDeliv[i, 0] == keyCar)
                    {
                        keys.Add(keyCarsDeliv[i, 1]);
                    }
                }
                data = dataDelivery;
                ShowInfoToDataGrid(dataGridViewDataRight, data, headersDelivery, keys);
            }
            else if (loadedFile == "DeliveryData.csv")
            {
                string keyDelivery = dataGridViewLoadData.Rows[rowIndex].Cells[0].Value.ToString();

                List<string> keys = new List<string>();
                for (int i = 0; i < keyEmpCars.GetLength(0); i++)
                {
                    if (keyEmpDeliv[i, 1] == keyDelivery)
                    {
                        keys.Add(keyEmpDeliv[i, 0]);
                    }
                }
                List<List<string>> data = dataEmployee;
                ShowInfoToDataGrid(dataGridViewDataLeft, data, headersEmployee, keys);

                keys.Clear();

                for (int i = 0; i < keyCarsDeliv.GetLength(0); i++)
                {
                    if (keyCarsDeliv[i, 1] == keyDelivery)
                    {
                        keys.Add(keyCarsDeliv[i, 0]);
                    }
                }
                data = dataCars;
                ShowInfoToDataGrid(dataGridViewDataRight, data, headersCars, keys);
            }

            if (!addingNewString)
                dataIsLoading = true;
            else
                dataIsLoading = false;
        }

        public void ShowInfoToDataGrid(DataGridView dataGridView, List<List<string>> data, string[] headers, List<string> keys)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();

            dataGridView.RowCount = data.Count;
            dataGridView.ColumnCount = headers.Length;

            for (int i = 0; i < headers.Length; i++)
            {
                dataGridView.Columns[i].HeaderText = headers[i];
            }
            dataGridView.RowHeadersWidth = 75;

            for (int i = 0; i < data.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < headers.Length; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = data[i][j];
                }
            }

            for (int i = 0; i < keys.Count; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (data[j][0] == keys[i])
                        dataGridView.Rows[j].Visible = true;
                    else
                        dataGridView.Rows[j].Visible = false;
                }
            }
        }

        private void dataGridViewLoadData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataIsLoading = false;
                this.toolStripMenuDoneItem.Enabled = true;
                this.toolStripMenuSaveItem.Enabled = false;
                if (e.RowIndex >= 0)
                    ShowMoreInfoAbout(e.RowIndex);
                toolStripMenuSaveItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuAddDataItem_Click(object sender, EventArgs e)
        {
            try
            {
                addingNewString = true;
                dataIsLoading = false;
                this.toolStripMenuLoadItem.Enabled = false;
                this.toolStripMenuSaveItem.Enabled = false;
                this.toolStripMenuDoneItem.Enabled = true;

                this.dataGridViewLoadData.Rows.Add();
                int rowIndex = dataGridViewLoadData.Rows.Count - 1;
                dataGridViewLoadData.Rows[rowIndex].HeaderCell.Value = (rowIndex + 1).ToString();

                for (int i = 0; i < dataGridViewLoadData.Columns.Count; i++)
                {
                    dataGridViewLoadData.Rows[rowIndex].Cells[i].Value = "";
                }

                this.dataGridViewDataLeft.Rows.Add();
                rowIndex = dataGridViewDataLeft.Rows.Count - 1;
                dataGridViewDataLeft.Rows[rowIndex].HeaderCell.Value = (rowIndex + 1).ToString();

                for (int i = 0; i < dataGridViewDataLeft.Columns.Count; i++)
                {
                    dataGridViewDataLeft.Rows[rowIndex].Cells[i].Value = "";
                }
                for (int i = 0; i < dataGridViewDataLeft.Rows.Count; i++)
                {
                    if (i != rowIndex)
                        dataGridViewDataLeft.Rows[i].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void SaveFiles(List<List<string>> list, string path, bool rewright) // Надо менять сохранение
        //{
        //    int rows = list.Count;
        //    int cols = list[0].Count;

        //    string[,] data = new string[rows, cols];

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            data[i, j] = dataGridView.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }

        //    ds.SaveDataToFile(data, path, rewright);
        //}

        private void toolStripMenuSaveItem_Click(object sender, EventArgs e)
        {
            toolStripMenuSaveItem.Enabled = false;
            ds.SaveDataToFile(dataEmployee, Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "EmployeeData.csv"), true);
            ds.SaveDataToFile(dataCars, Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "CarsData.csv"), true);
            ds.SaveDataToFile(dataDelivery, Path.Combine(Directory.GetCurrentDirectory(), "DataFiles", "DeliveryData.csv"), true);
            try
            {
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuDoneItem_Click(object sender, EventArgs e)
        {
            this.toolStripMenuDoneItem.Enabled = false;
            this.toolStripMenuLoadItem.Enabled = true;
            this.toolStripMenuSaveItem.Enabled = true;
            try
            {
                bool thereIsEmptyKeyField = false;

                for (int i = 0; i < dataGridViewLoadData.RowCount; i++)
                {
                    if (string.IsNullOrEmpty(dataGridViewLoadData.Rows[i].Cells[0].Value.ToString()))
                        thereIsEmptyKeyField = true;
                }

                for (int i = 0; i < dataGridViewDataLeft.RowCount; i++)
                {
                    if (string.IsNullOrEmpty(dataGridViewDataLeft.Rows[i].Cells[0].Value.ToString()))
                        thereIsEmptyKeyField = true;
                }

                for (int i = 0; i < dataGridViewDataRight.RowCount; i++)
                {
                    if (string.IsNullOrEmpty(dataGridViewDataRight.Rows[i].Cells[0].Value.ToString()))
                        thereIsEmptyKeyField = true;
                }

                if (!thereIsEmptyKeyField)
                {

                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateMainData(string side, int rowIndex, int colIndex)
        {
            if (side == "Main")
            {
                if (loadedFile == "EmployeeData.csv")
                {
                    dataEmployee[rowIndex][colIndex] = dataGridViewLoadData.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "CarsData.csv")
                {
                    dataCars[rowIndex][colIndex] = dataGridViewLoadData.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "DeliveryData.csv")
                {
                    dataDelivery[rowIndex][colIndex] = dataGridViewLoadData.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
            }
            else if (side == "Left")
            {
                if (loadedFile == "EmployeeData.csv")
                {
                    dataCars[rowIndex][colIndex] = dataGridViewDataLeft.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "CarsData.csv")
                {
                    dataEmployee[rowIndex][colIndex] = dataGridViewDataLeft.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "DeliveryData.csv")
                {
                    dataEmployee[rowIndex][colIndex] = dataGridViewDataLeft.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
            }
            else if (side == "Right")
            {
                if (loadedFile == "EmployeeData.csv")
                {
                    dataDelivery[rowIndex][colIndex] = dataGridViewDataRight.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "CarsData.csv")
                {
                    dataDelivery[rowIndex][colIndex] = dataGridViewDataRight.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
                if (loadedFile == "DeliveryData.csv")
                {
                    dataCars[rowIndex][colIndex] = dataGridViewDataRight.Rows[rowIndex].Cells[colIndex].Value.ToString();
                }
            }
        }

        private void dataGridViewLoadData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataIsLoading)
                    UpdateMainData("Main", e.RowIndex, e.ColumnIndex);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLeftData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataIsLoading)
                    UpdateMainData("Left", e.RowIndex, e.ColumnIndex);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRightData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataIsLoading)
                    UpdateMainData("Right", e.RowIndex, e.ColumnIndex);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemInformation_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }
}