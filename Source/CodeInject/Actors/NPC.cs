﻿using CodeInject.MemoryTools;
using CodeInject.WebServ.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;


namespace CodeInject.Actors
{
    public unsafe class  NPC: IObject
    {
        public long* ObjectPointer { get; set; }
        public ushort* ID { get; set; }
        public MobInfo Info { get; set; }
        public float* X { get; set; }
        public float* Y { get; set; }
        public float* Z { get; set; }
        public int* Hp { get; set; }
        public int* MaxHp { get; set; }

        public string* Name { get; set; }

        public NPC(long* Entry)
        {
            try//Walk around for error TODO:Fix it
            {
                ObjectPointer = (long*)*Entry;

                X = (float*)(*Entry + 0x10);
                Y = (float*)(*Entry + 0x14);
                Z = (float*)(*Entry + 0x18);
                if ((long*)(*Entry + 0x28) != null)
                ID = (ushort*)(*((long*)(*Entry + 0x20)));//0x368
                Hp = (int*)(*Entry + 0xF0);
                MaxHp = (int*)(*Entry + 0xF8);

                //Name = (string*)(*Entry + 0xbb0);

                Info = DataBase.GameDataBase.MonsterDatabase.FirstOrDefault(x => x.ID == (*(short*)(*Entry + 0x368)));
            }catch (Exception) { }
        }

        public double CalcDistance(IObject targetObject)
        {
            try//Walk around for error TODO:Fix it. Sometime getting null reference.
            {
                return Math.Sqrt(Math.Pow((*targetObject.X / 100) - (*this.X / 100), 2) + Math.Pow((*targetObject.Y / 100) - (*this.Y / 100), 2) + Math.Pow((*targetObject.Z / 100) - (*this.Z / 100), 2));
            }catch(Exception) {
            
            }
            return 0;
        }

        public NPCModel ToWSObject()
        {
            return new NPCModel
            {
                Hp = *Hp,
                MaxHp = *MaxHp,
                X = *X,
                Y = *Y,
                Z = *Z,
                Name = ToString()
            };
        }


        public double CalcDistance(float x,float y,float z)
        {
            return Math.Sqrt(
                  Math.Pow((x / 100) - (*this.X / 100), 2) 
                + Math.Pow((y / 100) - (*this.Y / 100), 2) 
                + Math.Pow((z / 100) - (*this.Z / 100), 2));
        }

        public override string ToString()
        {
            if(Info != null)
              return $"[{(*ID).ToString("X")}] {*Hp}/{*MaxHp} {Info.Name}";

            return $"[{(*ID).ToString("X")}] Unknow Object";
        }
    }
}
