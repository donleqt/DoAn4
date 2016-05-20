using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partition_Manager
{
    class DiskSector
    {
        public byte[] Data;

        public uint SectorSize { get; set; }

        public long Offset { get; set; }
    }
}
