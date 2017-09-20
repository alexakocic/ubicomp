using System.IO;
using System.Text;
using System.Timers;

namespace EcoCityCsv
{
    public class CsvReader
    {
        private readonly Timer _readTimer;
        private StreamReader[] _sensorsDataFiles;
        private readonly string _shortLetter;
        private readonly HttpHelper _httpHelper;

        public CsvReader()
        {
            _httpHelper = new HttpHelper();

            _readTimer = new Timer(Settings.Default.TimeInterval);
            _readTimer.Elapsed += ReadSensorData;

            _shortLetter = Settings.Default.ShortLetters;
        }

        /// <summary>
        /// Start sending data from files
        /// Files are defined in <see cref="Settings"/>
        /// </summary>
        public void StartReading()
        {
            // get all file paths from directory specified in settings
            var files = GetAllFileSensors();
            _sensorsDataFiles = new StreamReader[files.Length];

            // open Files for streaming
            for (var counter = 0; counter < files.Length; counter++)
            {
                _sensorsDataFiles[counter] = File.OpenText(files[counter]);
            }

            // skip first line
            foreach (var sensorFile in _sensorsDataFiles)
            {
                sensorFile.ReadLine();
            }

            // start timer
            _readTimer.Start();
        }

        private void ReadSensorData(object sender, ElapsedEventArgs e)
        {
            foreach (var sensorFile in _sensorsDataFiles)
            {
                var line = sensorFile.ReadLine();

                var fileStream = sensorFile.BaseStream as FileStream;
                
                if (fileStream != null)
                {
                    SendDataToOrion(line, Path.GetFileNameWithoutExtension(fileStream.Name));
                }
            }
        }

        private string[] GetAllFileSensors()
        {
            var path = Settings.Default.SensorDataPath;
            return Directory.GetFiles(path);
        }

        private void SendDataToOrion(string dataLine, string fileName)
        {
            var sensorData = dataLine.Split(',');

            StringBuilder plainText = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                plainText.Append($"{_shortLetter[i]}|{sensorData[i]}#");
            }

            plainText.Remove(plainText.Length-1, 1);

            _httpHelper.PostSensorData(plainText.ToString(), fileName);
        }
    }
}
