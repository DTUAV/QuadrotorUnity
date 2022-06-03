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
    public sealed class TwistStamp : LCM.LCM.LCMEncodable
    {
        public double timestamp;
        public geometry_msgs.Vector3 linear;
        public geometry_msgs.Vector3 angular;
 
        public TwistStamp()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x3d5a552a6b50c62bL;
 
        static TwistStamp()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("geometry_msgs.TwistStamp"))
                return 0L;
 
            classes.Add("geometry_msgs.TwistStamp");
            ulong hash = LCM_FINGERPRINT_BASE
                 + geometry_msgs.Vector3._hashRecursive(classes)
                 + geometry_msgs.Vector3._hashRecursive(classes)
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
            outs.Write(this.timestamp); 
 
            this.linear._encodeRecursive(outs); 
 
            this.angular._encodeRecursive(outs); 
 
        }
 
        public TwistStamp(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public TwistStamp(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static geometry_msgs.TwistStamp _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            geometry_msgs.TwistStamp o = new geometry_msgs.TwistStamp();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.timestamp = ins.ReadDouble();
 
            this.linear = geometry_msgs.Vector3._decodeRecursiveFactory(ins);
 
            this.angular = geometry_msgs.Vector3._decodeRecursiveFactory(ins);
 
        }
 
        public geometry_msgs.TwistStamp Copy()
        {
            geometry_msgs.TwistStamp outobj = new geometry_msgs.TwistStamp();
            outobj.timestamp = this.timestamp;
 
            outobj.linear = this.linear.Copy();
 
            outobj.angular = this.angular.Copy();
 
            return outobj;
        }
    }
}
