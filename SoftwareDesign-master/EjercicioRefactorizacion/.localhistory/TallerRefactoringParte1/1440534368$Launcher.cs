using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TallerRefactoringParte1 {
    public static class Launcher {
    
        public static void Main(string[] args){
            Application.Run(new FormularioSolicitud());
            Application.Exit();
        }
    }
}
