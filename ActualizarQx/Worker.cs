using BLL;
using System.Data;
using System.Text;

namespace ActualizarQx
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private Surgeries surgeries = new Surgeries();
        private ClassOperatingRoom Operatigrooms = new ClassOperatingRoom();
        private ClassGetStrings GetStrings = new ClassGetStrings();

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                ChangeStatusOperatingRoom();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
        public void ChangeStatusOperatingRoom()
        {
            try
            {
                string day = DateTime.Now.ToString("yyyy/MM/dd");
                DataTable dialySurgeries = surgeries.getDailySurgeries(day);

                foreach (DataRow item in dialySurgeries.Rows)
                {
                   // printDataRow(item);
                    string hora = item.Field<string>(1).ToString();
                    string numberQ = item.Field<string>(2).ToString();

                    string[] timeSep = GetStrings.getStrings(hora, new char[] { ':', ' ' });
                    string h = timeSep[0];
                    string m = timeSep[1];
                    string AorP = timeSep[2];
                    if (AorP == "A.M")
                    {
                        if (h == "12")
                        {
                            h = "00";
                        }
                    }
                    else if (AorP == "P.M")
                    {
                        h = ((Convert.ToInt32(h) % 12) + 12).ToString();
                    }

                    DateTime f1 = Convert.ToDateTime(h + ":" + m + ":00");
                    string f2 = f1.ToString("HH:mm");
                    string f3 = DateTime.Now.ToString("HH:mm");
                    TimeSpan t1 = TimeSpan.Parse(f2);
                    TimeSpan t2 = TimeSpan.Parse(f3);
                    int i = TimeSpan.Compare(t1, t2);



                    if (i == 0)
                    {
                        DataTable infoOperatingRooms = Operatigrooms.listoperatingRooms();

                        foreach (DataRow OpRoom in infoOperatingRooms.Rows)
                        {
                            int IdQ = OpRoom.Field<int>(0);
                            string numQ = OpRoom.Field<string>(1).ToString();

                            if ((numQ == numberQ))
                            {
                                string resp = Operatigrooms.editoperatingRoom(numQ, "Ocupado", true, IdQ);

                            }
                        }
                    }
                    else
                    {
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        private void printDataRow(DataRow drow)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Join(",", drow.ItemArray));
            Console.WriteLine(sb);
        }
    }
}