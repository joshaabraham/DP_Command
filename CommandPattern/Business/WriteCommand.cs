using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Business
{
    public class WriteCommand : Command
    {
        private FileDocument myFile;
        private StringBuilder draft;

        public StringBuilder Draft
        {
            get { return draft; }
            set { draft = value; }
        }

        public WriteCommand(FileDocument file, StringBuilder temp)
        {
            this.myFile = file;
            this.draft = temp;
        }

        public void execute() {
            this.myFile.Write(draft);
        }
    }
}
