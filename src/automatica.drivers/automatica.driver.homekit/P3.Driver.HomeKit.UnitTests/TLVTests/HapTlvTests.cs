﻿using P3.Driver.HomeKit.Hap.TlvData;
using P3.Driver.HomeKit.Hap.TlvData.Exceptions;
using Xunit;

namespace P3.Driver.HomeKit.UnitTests.TLVTests
{
    public class HapTlvTests
    {
        [Fact]
        public void TestPairSetupM1()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM1);


            Assert.Equal(2, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.Method));
            Assert.True(tlv.Values.ContainsKey(Constants.State));

            Assert.Equal(tlv.GetType(Constants.Method), new byte[] { 0 });
            Assert.Equal(tlv.GetType(Constants.State), new byte[] { 1 });
        }

        [Fact]
        public void TestPairSetupM2()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM2);

            Assert.Equal(3, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.State));
            Assert.True(tlv.Values.ContainsKey(Constants.Salt));
            Assert.True(tlv.Values.ContainsKey(Constants.PublicKey));


            Assert.Equal(tlv.GetType(Constants.State), new byte[] { 2 });
            Assert.Equal(tlv.GetType(Constants.Salt), new byte[] { 0x9e, 0x31, 0x7e, 0x30, 0x58, 0x10, 0xd5, 0x69, 0x2b, 0x73, 0x00, 0xd1, 0x63, 0x95, 0xe0, 0x03} );
            Assert.Equal(tlv.GetType(Constants.PublicKey), new byte[] {
                                                           0x4b, 0x20, 0x6a, 0x23, 0x3c, 0x2b, 0x33, 0xf0, 0x29, 0xf1,
                                                           0xd2, 0x82, 0xa4, 0xe1, 0x4c, 0xb9, 0x39, 0x96, 0x24, 0x99,
                                                           0x48, 0x3f, 0x48, 0xdb, 0xd7, 0x51, 0x3c, 0xb4, 0x3f, 0x9d,
                                                           0xcd, 0x73, 0x32, 0x61, 0x2e, 0xaf, 0x0f, 0xca, 0x70, 0x6d,
                                                           0xd1, 0x15, 0x93, 0xa5, 0x69, 0x81, 0xe1, 0xcd, 0x21, 0x09,
                                                           0x5c, 0x09, 0x38, 0x84, 0x96, 0x19, 0xbc, 0xcb, 0xd7, 0x1d,
                                                           0xf6, 0x5b, 0x2e, 0xe5, 0xe3, 0x74, 0x81, 0x78, 0xb7, 0x43,
                                                           0x14, 0x7f, 0x53, 0xad, 0x86, 0x5c, 0x19, 0xf0, 0x5f, 0xb7,
                                                           0x73, 0x10, 0x5b, 0xf4, 0xcb, 0x5a, 0x4a, 0x09, 0x84, 0xda,
                                                           0x4b, 0xaa, 0x63, 0x08, 0xc3, 0xd0, 0x46, 0xff, 0x3e, 0x24,
                                                           0xd6, 0xcf, 0xaa, 0xaf, 0xd8, 0x44, 0x76, 0xa9, 0x1d, 0x24,
                                                           0x0e, 0x5c, 0x58, 0xa4, 0x96, 0xf4, 0x85, 0x87, 0x94, 0x42,
                                                           0xc3, 0xb9, 0xd8, 0x1d, 0xe8, 0xb8, 0x14, 0x0d, 0x36, 0x8e,
                                                           0xc0, 0x0e, 0x67, 0x8e, 0xce, 0xb8, 0x0d, 0x1f, 0x22, 0x9c,
                                                           0xb5, 0x4d, 0x30, 0x9b, 0x81, 0x09, 0x23, 0xac, 0xcd, 0xc9,
                                                           0x8f, 0x89, 0x14, 0xb0, 0x74, 0x75, 0xd1, 0xfb, 0xee, 0x69,
                                                           0xb9, 0x2f, 0xaa, 0x6f, 0xce, 0x83, 0xfe, 0xbe, 0xae, 0xd1,
                                                           0x52, 0x8d, 0x21, 0x1b, 0x9e, 0x2b, 0xb2, 0xe1, 0x88, 0x2f,
                                                           0x0f, 0xfc, 0x2d, 0xf2, 0x0b, 0xe2, 0x51, 0x0d, 0xb4, 0xf4,
                                                           0xd9, 0x0e, 0x25, 0xce, 0x99, 0x6d, 0x42, 0x76, 0x50, 0xb3,
                                                           0x75, 0xcc, 0x98, 0x31, 0xc3, 0x4d, 0x50, 0x90, 0xd1, 0x2e,
                                                           0x3c, 0x3f, 0x94, 0x23, 0xef, 0xc6, 0x99, 0xf7, 0x60, 0x7a,
                                                           0x97, 0x30, 0x61, 0x43, 0xeb, 0x7a, 0x4d, 0x56, 0xfd, 0x26,
                                                           0x27, 0x88, 0x8b, 0xf4, 0xa7, 0x4d, 0x28, 0x94, 0x1e, 0x9a,
                                                           0xbf, 0xe2, 0x48, 0x19, 0xb7, 0x29, 0x96, 0xda, 0x3e, 0x4d,
                                                           0x84, 0xee, 0xcf, 0xe3, 0x82,

                                                           0x1f, 0x03, 0x9d, 0x75, 0x26, 0x37, 0xfd, 0x60, 0xbb, 0xbc,
                                                           0x47, 0xbd, 0x2e, 0x9a, 0xc8, 0xa0, 0x7d, 0x6e, 0x00, 0x09,
                                                           0x05, 0xe3, 0xc5, 0x78, 0x7b, 0x8d, 0x34, 0x1b, 0x4c, 0x1a,
                                                           0x02, 0xef, 0x3a, 0xcc, 0xf1, 0x34, 0xf2, 0x4a, 0x28, 0x9d,
                                                           0xc9, 0xa4, 0xdd, 0x0a, 0x2b, 0xee, 0xd3, 0x5c, 0x4e, 0x66,
                                                           0x18, 0xa2, 0x27, 0x00, 0x09, 0xb7, 0x32, 0x8e, 0x8a, 0x0b,
                                                           0x4a, 0x15, 0x04, 0xf9, 0x5e, 0x88, 0xf0, 0x6a, 0xf0, 0x02,
                                                           0x5b, 0xb4, 0x89, 0xfb, 0x3b, 0xc5, 0xdd, 0x36, 0xe4, 0xdd,
                                                           0xa7, 0x4f, 0xb7, 0xdf, 0x22, 0xbb, 0x03, 0x3c, 0xd7, 0xcd,
                                                           0xe1, 0x39, 0x17, 0x6f, 0x1d, 0xfa, 0xfd, 0xa1, 0x23, 0x3a,
                                                           0xf3, 0x15, 0x56, 0x08, 0xda, 0x57, 0x19, 0xd8, 0x10, 0x78,
                                                           0xd3, 0x89, 0xe1, 0x97, 0xa4, 0x0f, 0x77, 0x48, 0xae, 0x10,
                                                           0xf0, 0xcd, 0xd3, 0xb2, 0x71, 0xdb, 0x84, 0x23, 0x8f });
        }

        [Fact]
        public void TestPairSetupM3()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM3);


            Assert.Equal(3, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.State));
            Assert.True(tlv.Values.ContainsKey(Constants.PublicKey));
            Assert.True(tlv.Values.ContainsKey(Constants.Proof));

            Assert.Equal(tlv.GetType(Constants.State), new byte[] { 3 });
            Assert.Equal(tlv.GetType(Constants.PublicKey), new byte[] {
                                                           0x9e, 0xa8, 0xbb, 0x50, 0x00, 0xc3, 0x76, 0x47, 0x8d, 0x52,
                                                           0xa8, 0x94, 0xa0, 0xf2, 0xe2, 0x83, 0x4c, 0x93, 0xc5, 0x02,
                                                           0x0d, 0xc7, 0x94, 0xa7, 0x8e, 0xeb, 0x1a, 0xb5, 0xc2, 0xd2,
                                                           0xa8, 0x00, 0x51, 0x9b, 0x31, 0x15, 0x3f, 0xe2, 0x58, 0xda,
                                                           0x3b, 0x69, 0x53, 0x6a, 0x3d, 0xa5, 0x60, 0x7c, 0xaa, 0x70,
                                                           0x42, 0x97, 0x6c, 0x7b, 0xc7, 0xb8, 0xe4, 0x4b, 0x9e, 0x43,
                                                           0xbd, 0xd7, 0xe5, 0x2f, 0xc6, 0xd4, 0x91, 0xcb, 0x39, 0xd8,
                                                           0xf7, 0x85, 0x63, 0x99, 0x67, 0xa0, 0x61, 0xc9, 0x72, 0x56,
                                                           0x24, 0xfb, 0x3c, 0x31, 0xbe, 0x11, 0x6d, 0xab, 0xc6, 0x50,
                                                           0xd1, 0x65, 0x19, 0x87, 0xa6, 0xa1, 0xdf, 0xbf, 0xe2, 0x57,
                                                           0xb4, 0xa3, 0xed, 0x46, 0x09, 0x34, 0x3c, 0x8e, 0xd6, 0x88,
                                                           0xb2, 0x79, 0x32, 0xd4, 0x6d, 0x64, 0xc5, 0x31, 0xce, 0x61,
                                                           0x48, 0x86, 0x4b, 0x92, 0x0a, 0x3e, 0xf3, 0xdc, 0xff, 0xb5,
                                                           0x10, 0xb3, 0xf8, 0xca, 0x04, 0x04, 0xa0, 0x7f, 0x14, 0x82,
                                                           0x23, 0x8c, 0x32, 0x52, 0x37, 0x15, 0x7b, 0x53, 0xba, 0xd8,
                                                           0x91, 0x06, 0x31, 0xf3, 0x64, 0x52, 0xed, 0x81, 0xe8, 0xe1,
                                                           0x5b, 0xbe, 0x50, 0x9e, 0xdc, 0x2f, 0x92, 0x6a, 0xc2, 0xc6,
                                                           0xb4, 0x3e, 0x29, 0xbe, 0xeb, 0xf7, 0xb5, 0x17, 0x06, 0x83,
                                                           0x56, 0x01, 0xe6, 0x8f, 0x59, 0x21, 0x15, 0x8c, 0x72, 0xd5,
                                                           0x13, 0x47, 0x6a, 0x8e, 0x73, 0x65, 0x68, 0xa9, 0x6c, 0xe9,
                                                           0xce, 0xac, 0xb7, 0xd5, 0x29, 0x38, 0x50, 0x68, 0x8e, 0xf5,
                                                           0xfe, 0xec, 0xb9, 0x06, 0x5c, 0x4a, 0xf5, 0x41, 0xe1, 0x0c,
                                                           0x6d, 0x80, 0x23, 0x95, 0x71, 0x37, 0x6f, 0x97, 0xf3, 0x4d,
                                                           0xf8, 0x0c, 0xf3, 0x26, 0x45, 0x1b, 0x49, 0x38, 0xb9, 0xde,
                                                           0x9b, 0x24, 0x8d, 0xf3, 0xdb, 0x16, 0xa1, 0x50, 0x52, 0xbf,
                                                           0xa2, 0xc1, 0x02, 0x6f, 0x42,

                                                           0x71, 0xbd, 0x15, 0xe3, 0x66, 0x8c, 0xb3, 0x56, 0x36, 0xc3,
                                                           0xe7, 0x4b, 0x1f, 0xb0, 0xfb, 0x17, 0x0e, 0x50, 0x37, 0xde,
                                                           0xf8, 0xb7, 0x38, 0xd1, 0x35, 0x81, 0xd3, 0xfd, 0x16, 0x81,
                                                           0x48, 0xc5, 0x3f, 0x61, 0xab, 0x9f, 0x26, 0x0d, 0xa5, 0x1b,
                                                           0x4f, 0xa7, 0x40, 0x9b, 0x4b, 0xcf, 0x33, 0x4a, 0x30, 0x7f,
                                                           0x94, 0x7a, 0xd9, 0xb6, 0xf8, 0xf9, 0x50, 0x60, 0x2e, 0xa7,
                                                           0xf7, 0xe2, 0x20, 0x70, 0xd1, 0x49, 0x20, 0x6d, 0xf1, 0xb4,
                                                           0x37, 0x0a, 0x4c, 0xaa, 0x60, 0x69, 0xa8, 0xe9, 0x62, 0xd8,
                                                           0xd1, 0xb7, 0x54, 0xc7, 0xb3, 0xe4, 0x0b, 0x0c, 0xe1, 0xf3,
                                                           0xe3, 0x2d, 0xbe, 0xc2, 0xb5, 0xcb, 0x3e, 0x9c, 0x7a, 0x3e,
                                                           0xf1, 0x53, 0x3d, 0x71, 0xae, 0x04, 0xf3, 0x07, 0x0f, 0x32,
                                                           0xf2, 0x53, 0x73, 0x26, 0xbc, 0x14, 0x50, 0x38, 0xd4, 0x5a,
                                                           0xb1, 0x0f, 0xed, 0x15, 0x3f, 0xa1, 0x70, 0x07, 0xbc,
                                                   });
            Assert.Equal(tlv.GetType(Constants.Proof), new byte[] { 0x54, 0xa2, 0x3c, 0x5b, 0xb1, 0x0a, 0xc8, 0x78,
                0x8a, 0xb4, 0xbe, 0x87, 0x94, 0x3c, 0x30, 0xd2,
                0x77, 0x8c, 0xa3, 0xeb, 0x98, 0xcf, 0x6c, 0xbb,
                0x37, 0x9b, 0x66, 0x37, 0x0a, 0x0c, 0xa3, 0xe0,
                0x13, 0x36, 0x99, 0x50, 0x84, 0xc2, 0xef, 0xbc,
                0x67, 0x51, 0xa0, 0xa8, 0x5b, 0x1d, 0x62, 0x75,
                0xbd, 0x40, 0x19, 0x92, 0xa6, 0x44, 0xa6, 0x5f,
                0x69, 0xbe, 0xd2, 0xc2, 0x03, 0x4e, 0x69, 0x74 });
        }

        [Fact]
        public void TestPairSetupM4()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM4);

            Assert.Equal(2, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.State));
            Assert.True(tlv.Values.ContainsKey(Constants.Proof));

            Assert.Equal(tlv.GetType(Constants.State), new byte[] { 4 });
            Assert.Equal(tlv.GetType(Constants.Proof), new byte[] { 0x5f, 0x7a, 0x20, 0xd3, 0x4d, 0x1f, 0x16, 0x8f,
                0x2b, 0x5f, 0x0f, 0xcd, 0x0c, 0x7f, 0xe3, 0x27,
                0xa5, 0x40, 0xa5, 0x51, 0x7c, 0xf7, 0x0b, 0x7e,
                0x2a, 0x34, 0x88, 0x01, 0x48, 0x90, 0x7e, 0xe4,
                0x25, 0xf2, 0x6c, 0xb0, 0xbd, 0x63, 0x2a, 0xa0,
                0x39, 0x98, 0xc8, 0xc8, 0x7b, 0xbb, 0xcd, 0xdc,
                0x2f, 0x0d, 0x08, 0x89, 0xb7, 0x70, 0x0a, 0xf8,
                0x1c, 0x46, 0xb6, 0x31, 0x83, 0x3f, 0x57, 0xf9 });

        }

        [Fact]
        public void TestPairSetupM5()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM5);

            Assert.Equal(2, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.State));
            Assert.True(tlv.Values.ContainsKey(Constants.EncryptedData));

            Assert.Equal(tlv.GetType(Constants.State), new byte[] {5});
            Assert.Equal(tlv.GetType(Constants.EncryptedData),
                new byte[]
                {
                    0xef, 0x74, 0x54, 0x5d, 0xab, 0x72, 0xfb, 0xcc, 0x34,
                    0x02, 0xd9, 0x0b, 0x79, 0xcc, 0xd1, 0xa6, 0x00, 0x66,
                    0x4f, 0xf8, 0x2b, 0x30, 0x3a, 0x64, 0x1b, 0xa7, 0xe5,
                    0xf9, 0xef, 0xe3, 0xda, 0x5c, 0x9c, 0x0d, 0x67, 0x46,
                    0x7d, 0x7e, 0x05, 0x3c, 0xd3, 0x32, 0x30, 0x6e, 0xc6,
                    0xc6, 0x06, 0xfa, 0x38, 0x69, 0x20, 0xb7, 0x33, 0xfd,
                    0xfd, 0x25, 0x1e, 0xe7, 0xd9, 0x4b, 0x31, 0x5a, 0xc6,
                    0x51, 0x02, 0xaf, 0x8b, 0x08, 0x6e, 0x95, 0x25, 0xbd,
                    0x93, 0xa9, 0x2b, 0x62, 0xc3, 0x6d, 0xdb, 0x01, 0xde,
                    0xe9, 0x46, 0x15, 0x78, 0x18, 0x87, 0xc5, 0x7d, 0x2e,
                    0xd7, 0x8a, 0x4e, 0x7b, 0x2d, 0x3a, 0x59, 0x17, 0xb7,
                    0xe1, 0x69, 0x4e, 0x86, 0x74, 0xc0, 0xaa, 0xf7, 0xe7,
                    0xea, 0x46, 0x67, 0xf8, 0xea, 0x4f, 0x1f, 0x59, 0x75,
                    0xd4, 0x6f, 0x01, 0x30, 0xf1, 0x7a, 0x72, 0x1e, 0x38,
                    0x72, 0x47, 0xdc, 0x2f, 0x1b, 0x1f, 0xea, 0x5e, 0xd0,
                    0x8d, 0x0d, 0x8a, 0x1c, 0x22, 0x67, 0xd9, 0xf9, 0x3f,
                    0xb8, 0xf0, 0xe8, 0xbe, 0x5a, 0x58, 0x06, 0x19, 0x85,
                    0x7a
                });

        }

        [Fact]
        public void TestPairSetupM6()
        {
            var tlv = TlvParser.Parse(TlvTestData.PairSetupM6);


            Assert.Equal(2, tlv.Values.Count);
            Assert.True(tlv.Values.ContainsKey(Constants.State));
            Assert.True(tlv.Values.ContainsKey(Constants.EncryptedData));


            Assert.Equal(tlv.GetType(Constants.State), new byte[] {6});
            Assert.Equal(tlv.GetType(Constants.EncryptedData),
                new byte[]
                {
                    0x8b, 0xc8, 0x42, 0xd6, 0xb8, 0x60, 0xac, 0x76, 0x36,
                    0xe8, 0xb0, 0xe5, 0xc7, 0x7a, 0x5b, 0x56, 0x23, 0xc4,
                    0xd4, 0x83, 0x2f, 0xdb, 0x16, 0x24, 0x50, 0x27, 0x7f,
                    0xd5, 0xdd, 0xd5, 0x11, 0x9d, 0x5f, 0x95, 0xba, 0xd7,
                    0xe0, 0xdd, 0x46, 0x52, 0xa8, 0xaf, 0xd1, 0xc0, 0xe7,
                    0x41, 0x2e, 0x5c, 0x54, 0x63, 0x59, 0x55, 0x24, 0x2c,
                    0xa1, 0x3e, 0xfb, 0xd7, 0xa7, 0xd1, 0x8d, 0xdc, 0x03,
                    0x1d, 0x14, 0x3c, 0x2f, 0x3b, 0x7d, 0x4d, 0x29, 0xf1,
                    0x33, 0xe8, 0x68, 0x79, 0x62, 0x52, 0xd6, 0x16, 0x5c,
                    0x7f, 0x57, 0xb2, 0xda, 0xbe, 0xe4, 0xb8, 0xfc, 0xb6,
                    0xf8, 0x3d, 0x3b, 0xa4, 0xb0, 0x19, 0x3e, 0xf9, 0x25,
                    0x2d, 0xe1, 0x2c, 0xab, 0x93, 0x10, 0xfc, 0x08, 0x7e,
                    0x59, 0x3b, 0x7a, 0x70, 0x83, 0x4c, 0xf8, 0x46, 0xab,
                    0x87, 0x83, 0xa1, 0x67, 0x29, 0xe7, 0x05, 0x5b, 0x8f,
                    0x73, 0x1c, 0x57, 0x2f, 0xea, 0xec, 0x33, 0xbe, 0xd5
                });
        }

        [Fact]
        public void TestBorderCaseLength255()
        {
            var tlv = TlvParser.Parse(TlvTestData.BorderCaseLength255);
            
            Assert.Single(tlv.Values);
            Assert.True(tlv.Values.ContainsKey(Constants.Method));

            Assert.Equal(tlv.GetType(Constants.Method), new byte[] {
                                                           0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a,
                                                           0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14,
                                                           0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                                                           0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28,
                                                           0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32,
                                                           0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c,
                                                           0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46,
                                                           0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50,
                                                           0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a,
                                                           0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64,
                                                           0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e,
                                                           0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78,
                                                           0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x80, 0x81, 0x82,
                                                           0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c,
                                                           0x8d, 0x8e, 0x8f, 0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
                                                           0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0xa0,
                                                           0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa,
                                                           0xab, 0xac, 0xad, 0xae, 0xaf, 0xb0, 0xb1, 0xb2, 0xb3, 0xb4,
                                                           0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe,
                                                           0xbf, 0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8,
                                                           0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0xd0, 0xd1, 0xd2,
                                                           0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc,
                                                           0xdd, 0xde, 0xdf, 0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6,
                                                           0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0xf0,
                                                           0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa,
                                                           0xfb, 0xfc, 0xfd, 0xfe, 0xff });
        }

        [Fact]
        public void TestBorderCaseLength0()
        {
            var tlv = TlvParser.Parse(TlvTestData.BorderCaseLength0);
            Assert.Single(tlv.Values);
            Assert.True(tlv.Values.ContainsKey(Constants.Method));

            Assert.Equal(tlv.GetType(Constants.Method), new byte[] { });
        }

        [Fact]
        public void TestBorderCaseLargeTlvItem()
        {
            var tlv = TlvParser.Parse(TlvTestData.BorderVeryLongTlv);

            Assert.Single(tlv.Values);
            Assert.True(tlv.Values.ContainsKey(Constants.Method));

            Assert.Equal(tlv.GetType(Constants.Method), new byte[]
            {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a,
                0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14,
                0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28,
                0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32,
                0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c,
                0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46,
                0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50,
                0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a,
                0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64,
                0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e,
                0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78,
                0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x80, 0x81, 0x82,
                0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c,
                0x8d, 0x8e, 0x8f, 0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
                0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0xa0,
                0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa,
                0xab, 0xac, 0xad, 0xae, 0xaf, 0xb0, 0xb1, 0xb2, 0xb3, 0xb4,
                0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe,
                0xbf, 0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8,
                0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0xd0, 0xd1, 0xd2,
                0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc,
                0xdd, 0xde, 0xdf, 0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6,
                0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0xf0,
                0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa,
                0xfb, 0xfc, 0xfd, 0xfe, 0xff,

                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a,
                0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14,
                0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28,
                0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32,
                0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c,
                0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46,
                0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50,
                0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a,
                0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64,
                0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e,
                0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78,
                0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x80, 0x81, 0x82,
                0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c,
                0x8d, 0x8e, 0x8f, 0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
                0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0xa0,
                0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa,
                0xab, 0xac, 0xad, 0xae, 0xaf, 0xb0, 0xb1, 0xb2, 0xb3, 0xb4,
                0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe,
                0xbf, 0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8,
                0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0xd0, 0xd1, 0xd2,
                0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc,
                0xdd, 0xde, 0xdf, 0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6,
                0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0xf0,
                0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa,
                0xfb, 0xfc, 0xfd, 0xfe, 0xff,

                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a,
                0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14,
                0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28,
                0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32,
                0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c,
                0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46,
                0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50,
                0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a,
                0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64,
                0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e,
                0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78,
                0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x80, 0x81, 0x82,
                0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c,
                0x8d, 0x8e, 0x8f, 0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
                0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0xa0,
                0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa,
                0xab, 0xac, 0xad, 0xae, 0xaf, 0xb0, 0xb1, 0xb2, 0xb3, 0xb4,
                0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe,
                0xbf, 0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8,
                0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0xd0, 0xd1, 0xd2,
                0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc,
                0xdd, 0xde, 0xdf, 0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6,
                0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0xf0,
                0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa,
                0xfb, 0xfc, 0xfd, 0xfe, 0xff,

                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a,
                0x0b, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14,
                0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28,
                0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x30, 0x31, 0x32,
                0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c,
                0x3d, 0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46,
                0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x50,
                0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a,
                0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64,
                0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e,
                0x6f, 0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78,
                0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x80, 0x81, 0x82,
                0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c,
                0x8d, 0x8e, 0x8f, 0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
                0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0xa0,
                0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa,
                0xab, 0xac, 0xad, 0xae, 0xaf, 0xb0, 0xb1, 0xb2, 0xb3, 0xb4,
                0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe,
                0xbf, 0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8,
                0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0xd0, 0xd1, 0xd2,
                0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc,
                0xdd, 0xde, 0xdf, 0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6,
                0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0xf0,
                0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa,
                0xfb, 0xfc, 0xfd, 0xfe, 0xff
            });
        }

        [Fact]
        public void TestEveryTlvTypeSingleAndNotFragmented()
        {
            Assert.Throws<TlvTypeDuplicationException>(() => TlvParser.Parse(TlvTestData.EveryTlvNotFragmented));
        }

        [Fact]
        public void TestEveryTlvFragmentMustHaveNon0Length()
        {
            Assert.Throws<TlvFragmentLengthException>(() => TlvParser.Parse(TlvTestData.EveryTlvFragmentNon0Length));
        }

        [Fact]
        public void TestOnlyLastTlvFragmentItemInContiguousTlvMyHaveNon255Length()
        {
            Assert.Throws<TlvFragmentLengthException>(() => TlvParser.Parse(TlvTestData.OnlyLastTlvMayHaveNo255Length));
        }

    }
}