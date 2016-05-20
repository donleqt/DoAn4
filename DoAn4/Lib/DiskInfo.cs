using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partition_Manager
{
    class DiskInfo
    {
        public uint BytesPerSector;
        public string diskID;
        public ulong Size;

        public DiskInfo(string diskID)
        {
            // TODO: Complete member initialization
            this.diskID = diskID;
        }
    }
}
