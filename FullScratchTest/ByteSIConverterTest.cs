using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullScratch.Models;

namespace FullScratchTest
{
    [TestClass]
    public class ByteSIConverterTest
    {
        [TestMethod]
        public void ByteにSI接頭辞を付加できる()
        {
            var BC = new ByteSIConverter();
            Assert.AreEqual("1023B", BC.Convert((long)1023,typeof(long),null,null));
            Assert.AreEqual("1KB", BC.Convert((long)1024, typeof(long), null, null));
            Assert.AreEqual("1MB", BC.Convert((long)1048576, typeof(long), null, null));
            Assert.AreEqual("1GB", BC.Convert((long)1073741824, typeof(long), null, null));
            Assert.AreEqual("1TB", BC.Convert((long)1099511627776, typeof(long), null, null));
        }
    }
}
