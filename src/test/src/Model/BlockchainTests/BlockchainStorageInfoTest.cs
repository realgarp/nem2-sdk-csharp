﻿//
// Copyright 2018 NEM
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using io.nem2.sdk.Model.Blockchain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test.Model.BlockchainTests
{
    [TestClass]
    public class BlockchainStorageInfoTest
    {
        [TestMethod]
        public void CreateANewBlockchainStorageInfo()
        {
            BlockchainStorageInfo blockchainStorageInfo = new BlockchainStorageInfo(1,2,3);

            Assert.AreEqual(blockchainStorageInfo.NumAccounts, 1);
            Assert.AreEqual(blockchainStorageInfo.NumBlocks, 2);
            Assert.AreEqual(blockchainStorageInfo.NumTransactions, 3);
        }
    }
}
