/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace geometry_msgs
{
    public sealed class TransformNew : LCM.LCM.LCMEncodable
    {
        public geometry_msgs.Vector3 translation;
        public geometry_msgs.Quaternion rotation;
 
        public TransformNew()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x1275bd1ccbdaf47fL;
 
        static TransformNew()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("geometry_msgs.TransformNew"))
                return 0L;
 
            classes.Add("geometry_msgs.TransformNew");
            ulong hash = LCM_FINGERPRINT_BASE
                 + geometry_msgs.Vector3._hashRecursive(classes)
                 + geometry_msgs.Quaternion._hashRecursive(classes)
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            this.translation._encodeRecursive(outs); 
 
            this.rotation._encodeRecursive(outs); 
 
        }
 
        public TransformNew(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public TransformNew(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static geometry_msgs.TransformNew _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            geometry_msgs.TransformNew o = new geometry_msgs.TransformNew();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.translation = geometry_msgs.Vector3._decodeRecursiveFactory(ins);
 
            this.rotation = geometry_msgs.Quaternion._decodeRecursiveFactory(ins);
 
        }
 
        public geometry_msgs.TransformNew Copy()
        {
            geometry_msgs.TransformNew outobj = new geometry_msgs.TransformNew();
            outobj.translation = this.translation.Copy();
 
            outobj.rotation = this.rotation.Copy();
 
            return outobj;
        }
    }
}

