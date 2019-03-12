using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    [Serializable]
    public class CarDoc
    {
        public List<PictureBox> Cars { get; set; }
        public int speed { get; set; }
        public int score { get; set; }

        public CarDoc()
        {
            Cars = new List<PictureBox>();
            speed = 3;
            score = 0;
        }

        public void AddCar(PictureBox c)
        {
            Cars.Add(c);

        }
    }
}
