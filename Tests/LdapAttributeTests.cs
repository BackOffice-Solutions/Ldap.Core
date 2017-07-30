﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Flexinets.Ldap.Core.Tests
{
    [TestClass]
    public class LdapAttributeTests
    {
        [TestMethod]
        public void TestLdapAttributeGetBytes()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.Integer, false, (Byte)1);
            Assert.AreEqual("020101", Utils.ByteArrayToString(attribute.GetBytes()));
        }


        [TestMethod]
        public void TestLdapAttributeGetBytes2()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.Integer, false, (Byte)2);
            Assert.AreEqual("020102", Utils.ByteArrayToString(attribute.GetBytes()));
        }


        [TestMethod]
        public void TestLdapAttributeGetBytesMaxInt()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.Integer, false, Int32.MaxValue);
            Assert.AreEqual(Int32.MaxValue, attribute.GetValue<Int32>());
        }


        [TestMethod]
        public void TestLdapAttributeGetBytesBoolean()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.Boolean, false, true);
            Assert.AreEqual("010101", Utils.ByteArrayToString(attribute.GetBytes()));
        }


        [TestMethod]
        public void TestLdapAttributeGetBytesBoolean2()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.Boolean, false, false);
            Assert.AreEqual("010100", Utils.ByteArrayToString(attribute.GetBytes()));
        }


        [TestMethod]
        public void TestLdapAttributeGetBytesString()
        {
            var attribute = new LdapUniversalAttribute(UniversalDataType.OctetString, false, "dc=karakorum,dc=net");
            Assert.AreEqual("041364633d6b6172616b6f72756d2c64633d6e6574", Utils.ByteArrayToString(attribute.GetBytes()));
        }
  

        [TestMethod]
        public void TestAttributeClass2()
        {
            var attribute = new LdapApplicationAttribute(LdapOperation.BindRequest, true);
            Assert.AreEqual(LdapOperation.BindRequest, attribute.LdapOperation);
        }
    }
}
