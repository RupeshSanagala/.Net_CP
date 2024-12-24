using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTasks
{
    internal class PhotoBook
    {
        private int numPages;
        public int GetNoOfPages()
        {
            return numPages;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        
    }
    class BigPhotoBook
    {
        private int numPages1;
        public BigPhotoBook(int numPages1)
        {
            this.numPages1 = numPages1;
        }
        public int GetNoOfPages1()
        {
            return numPages1;
        }
    }
}
