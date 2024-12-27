namespace Tyuiu.BrovkinAA.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public string[,] LoadDataFromFile(string path)
        {
            int rows = 0;
            int cols = 0;
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        rows++;
                        if (rows == 1)
                        {
                            cols = line.Split(';').Length;
                        }
                    }
                }
            }

            string[,] dataResult = new string[rows, cols];

            using (StreamReader sr = new StreamReader(path))
            {
                string[] words;
                int row = 0;
                while ((line= sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        words = line.Split(";");
                        for (int i = 0; i < words.Length; i++)
                        {
                            dataResult[row, i] = words[i].Trim();
                        }
                        row++;
                    }
                }
            }

            return dataResult;
        }

        public List<List<string>> StringToListTranslate(string[,] data)
        {
            List<List<string>> list = new List<List<string>>();

            for (int i = 0; i < data.GetLength(0);i++)
            {
                List<string> row = new List<string>();
                for (int j = 0;  j < data.GetLength(1);j++)
                {
                    row.Add(data[i,j].ToString());
                }
                list.Add(row);
            }

            return list;
        }

        public void SaveDataToFile(List<List<string>> data, string path, bool rewright)
        {

            if (rewright)
                File.Delete(path);

            for (int i = 0;i < data.Count;i++)
            {
                string line = "";
                for (int j = 0; j < data[0].Count;j++)
                {
                    line +=  " " + data[i][j].ToString();                    
                }
                line = line.Trim();
                line = line.Replace(' ', ';');
                File.AppendAllText(path, line);
            }
        }
    }
}
