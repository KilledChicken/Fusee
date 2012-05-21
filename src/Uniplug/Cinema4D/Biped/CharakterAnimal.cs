﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C4d;
using Fusee.Math.Core;

namespace RigPlugin
{
    class CharakterAnimal : Character
    {
        public CharakterAnimal(GeListNode node, DescriptionCommand desc)
        {
            this.b = GetDataInstance(node);
            this.button = desc.id.GetAt(0).id;
            this.doc = C4dApi.GetActiveDocument();//Speichern aller Elemente im Dokument in die Variable doc
            this.myMesh = b.GetObjectLink(SKELETT_OBJ_AUSWAHL, doc); //selektiertes Object in die Variable ObjSe speichern
            this.mcd = new ModelingCommandData(this.doc, this.myMesh, this.myMesh.GetDataInstance(), MODELINGCOMMANDMODE.MODELINGCOMMANDMODE_ALL, MODELINGCOMMANDFLAGS.MODELINGCOMMANDFLAGS_CREATEUNDO, null, null);

            /**
             * Bisheriges speichern und in die Szene zeichnen
             */
            C4dApi.EventAdd();

            /**
             * Wichtungstag definieren
             */
            //this.wtag = CAWeightTag.Alloc();
            this.wtagBaseTag = BaseTag.Alloc(C4dApi.Tweights);
            /**
             * Wichtungstag in das BaseObject einbauen
             */
            //this.myMesh.InsertTag(this.wtag);
            this.myMesh.InsertTag(wtagBaseTag);
            /**
             * Standard BaseObject vom Typ Joint erstellen, diese sind bei Menschen immer aktiv
             */
            //Rückenknochen
            BaseObject[] jointSpineArr = this.allocBonesSwing("Spine", this.myMesh, this.b.GetLong(SKELETT_RUECKENWIRBEL), new Vector3D(50, -2, 0));
            //Nackenknochen
            BaseObject jointNeck = this.allocBonesCurveY("Neck", jointSpineArr[0], this.b.GetLong(SKELETT_HALSWIRBEL), new Vector3D(-100, 0, 0));
            //Kopf
            BaseObject jointHead = this.allocJoint("Head", jointNeck, new Vector3D(-100,0,0));
            this.wtag.AddJoint(jointHead);


            if (this.b.GetLong(SKELETT_BEINE) > 0)
            {
                this.addLegsFront(jointSpineArr[0]);
                if (this.b.GetLong(SKELETT_BEINE) >= 3)
                {
                    this.addLegsBack(jointSpineArr[1]);
                }
            }
            
            //Schwanz
            if (this.b.GetLong(SKELETT_RUECKENWIRBEL) > 0 && this.b.GetLong(SKELETT_SCHWANZ) > 0)
            {
                BaseObject parent = jointSpineArr[1];
                for (int i = 0; i < this.b.GetLong(SKELETT_SCHWANZ); i++)
                {
                    BaseObject jointTail = this.allocJoint("Tail_" + i, parent, new Vector3D(100, -50, 0));
                    this.wtag.AddJoint(jointTail);
                    parent = jointTail;
                }
            }

            /**
             * Debug Ausgabe erstellen
             */
            C4dApi.GePrint("Der Joint wurde angelegt");
            jointSpineArr[0].GetTag(C4dApi.Tweights);

            /**
             * Skin Objekt einfügen
             */

            BaseObject skin = BaseObject.Alloc(C4dApi.Oskin);
            if (skin != null)
            {
                skin.InsertUnder(this.myMesh);
            }

            /**
             * Zur Szene hinzufügen
             */
            C4dApi.EventAdd();
            C4dApi.GePrint("anzal der bones: " + this.wtag.GetJointCount());
            doc.SetActiveObject(this.myMesh);//Selektiert das Model im OM
            
        }
        public CAWeightTag getwtagJoint()
        {
            return this.wtag;
        }
        private void addLegsFront(BaseObject parent)
        {
            //Vorderbeine
            BaseObject jointFL_Leg = this.allocJoint("Leg_FL_1", parent, new Vector3D(0, 0, -50));
            BaseObject jointFL_Leg1 = this.allocJoint("Leg_FL_2", jointFL_Leg, new Vector3D(-100, -75, 0));
      
            BaseObject jointFL_Leg2 = this.allocJoint("Leg_FL_3", jointFL_Leg1, new Vector3D(0, -120, 0));
            BaseObject jointFL_Leg4 = this.allocJoint("Leg_FL_4", jointFL_Leg2, new Vector3D(-50, -100, 0));

            this.wtag.AddJoint(jointFL_Leg);
            this.wtag.AddJoint(jointFL_Leg1);
            this.wtag.AddJoint(jointFL_Leg2);
            this.wtag.AddJoint(jointFL_Leg4);

            //Vorderer Fuß
            if (this.b.GetLong(SKELETT_FUESSE) > 0)
            {
                BaseObject jointFL_Feet = this.allocJoint("Feet", jointFL_Leg4, new Vector3D(-50, 0, 0));
                this.wtag.AddJoint(jointFL_Feet);
            }

            if (this.b.GetLong(SKELETT_BEINE) > 1)
            {
                //Vorderbeine
                BaseObject jointFR_Leg = this.allocJoint("Leg_FR_1", parent, new Vector3D(0, 0, 50));
                BaseObject jointFR_Leg1 = this.allocJoint("Leg_FR_2", jointFR_Leg, new Vector3D(-100, -75, 0));

                BaseObject jointFR_Leg2 = this.allocJoint("Leg_FR_3", jointFR_Leg1, new Vector3D(0, -120, 0));
                BaseObject jointFR_Leg4 = this.allocJoint("Leg_FR_4", jointFR_Leg2, new Vector3D(-50, -100, 0));

                this.wtag.AddJoint(jointFR_Leg);
                this.wtag.AddJoint(jointFR_Leg1);
                this.wtag.AddJoint(jointFR_Leg2);

                this.wtag.AddJoint(jointFR_Leg4);

                if (this.b.GetLong(SKELETT_FUESSE) > 1)
                {
                    //Vorderer Fuß
                    BaseObject jointFR_Feet = this.allocJoint("Feet", jointFR_Leg4, new Vector3D(-50, 0, 0));
                    this.wtag.AddJoint(jointFR_Feet);
                }
            }
        }

        private void addLegsBack(BaseObject parent)
        {
            //Hinterbeine
            BaseObject jointBL_Leg = this.allocJoint("Leg_BL_1", parent, new Vector3D(0, 0, -50));
            BaseObject jointBL_Leg1 = this.allocJoint("Leg_BL_2", jointBL_Leg, new Vector3D(-100, -150, 0));
            BaseObject jointBL_Leg2 = this.allocJoint("Leg_BL_3", jointBL_Leg1, new Vector3D(110, -80, 0));
            BaseObject jointBL_Leg3 = this.allocJoint("Leg_BL_4", jointBL_Leg2, new Vector3D(-65, -140, 0));

            this.wtag.AddJoint(jointBL_Leg);
            this.wtag.AddJoint(jointBL_Leg1);
            this.wtag.AddJoint(jointBL_Leg2);
            this.wtag.AddJoint(jointBL_Leg3);

            //Hinterer Fuß
            if (this.b.GetLong(SKELETT_FUESSE) > 2)
            {
                BaseObject jointBL_Feet = this.allocJoint("Feet_BL", jointBL_Leg3, new Vector3D(-50, 0, 0));
                this.wtag.AddJoint(jointBL_Feet);
            }

            if (this.b.GetLong(SKELETT_BEINE) > 3)
            {
                BaseObject jointBR_Leg = this.allocJoint("Leg_BR_1", parent, new Vector3D(0, 0, 50));
                BaseObject jointBR_Leg1 = this.allocJoint("Leg_BR_2", jointBR_Leg, new Vector3D(-100, -150, 0));
                BaseObject jointBR_Leg2 = this.allocJoint("Leg_BR_3", jointBR_Leg1, new Vector3D(110, -80, 0));
                BaseObject jointBR_Leg3 = this.allocJoint("Leg_BR_4", jointBR_Leg2, new Vector3D(-65, -140, 0));

                this.wtag.AddJoint(jointBR_Leg);
                this.wtag.AddJoint(jointBR_Leg1);
                this.wtag.AddJoint(jointBR_Leg2);
                this.wtag.AddJoint(jointBR_Leg3);

                if (this.b.GetLong(SKELETT_FUESSE) > 3)
                {
                    //Vorderer Fuß
                    BaseObject jointBR_Feet = this.allocJoint("Feet", jointBR_Leg3, new Vector3D(-50, 0, 0));
                    this.wtag.AddJoint(jointBR_Feet);
                }
            }
        }
    }
}
