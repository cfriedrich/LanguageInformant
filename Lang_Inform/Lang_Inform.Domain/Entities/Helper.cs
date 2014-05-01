using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;

namespace Lang_Inform.Domain.Entities  
{
    public class Helper
    {
        public static Stream byteArrayToStream(Byte[] bytes)
        {
            // A comment
            Stream str = new MemoryStream(bytes);
            return str;
        }
    }
}
