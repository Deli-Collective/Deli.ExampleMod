﻿using System;
using System.IO;
using System.Text;
using Deli;
using UnityEngine;
using Valve.Newtonsoft.Json;

namespace DeliExampleMod
{
    // Asset readers are classes which allow you to easily read a resource from a mod as a certain type.
    // In this case, we make an asset reader for our ExampleAsset
    [QuickUnnamedBind]
    public class ExampleAssetReader : IAssetReader<ExampleJsonAsset>
    {
        public ExampleJsonAsset ReadAsset(byte[] raw)
        {
            // Decode the string from the raw bytes
            var str = Encoding.UTF8.GetString(raw);
            
            // Return our parsed asset.
            return new ExampleJsonAsset
            {
                Message = str
            };
        }
    }
}