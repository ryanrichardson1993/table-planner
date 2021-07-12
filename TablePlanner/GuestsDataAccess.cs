using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TablePlanner
{
    public class GuestsDataAccess
    {
        public List<Guest> GetGuestsFromCsv()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV Files (*.csv)|*.csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return null;
                }
                
                var filePath = dialog.FileName;

                var lines = File.ReadAllLines(filePath)
                                .Skip(1);

                var guests = new List<Guest>();

                foreach (var line in lines)
                {
                    if (line.Contains("Total"))
                    {
                        break;
                    }

                    var fields = line.Split(',');

                    guests.Add(
                        new Guest(fields.First().Trim())
                        {
                            Coming = fields[2] == "Y",
                            Alcohol = fields[3] == "Y",
                            DietaryRequirements = fields[4],
                            HighChair = fields[5] == "Y"
                        }
                    );
                }

                return guests.Where(x => x.Coming).ToList();
            }
        }
    }
}
