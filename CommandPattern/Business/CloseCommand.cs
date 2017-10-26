using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Business
{
    public class CloseCommand : Command
    {
        private FileDocument myFile;

        public CloseCommand(FileDocument file) {
            this.myFile = file;
        }

        public void execute() {
            this.myFile.CloseFile();
        }
    }
}
