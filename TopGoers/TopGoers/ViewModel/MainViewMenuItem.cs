using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGoers.View;

namespace TopGoers.ViewModel
{
    public interface IMainViewMenuItem
    {
        int Id { get; set; }
        string Title { get; set; }
        Type TargetType { get; set; }
    }

    public class MainViewMenuItem : IMainViewMenuItem
    {
        public MainViewMenuItem()
        {
            TargetType = typeof(MainViewDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}