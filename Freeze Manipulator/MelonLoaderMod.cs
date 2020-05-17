using MelonLoader;
using StressLevelZero;
using BoneworksModdingToolkit;
using UnityEngine;
using StressLevelZero.Props.Weapons;
using Il2CppSystem.Runtime.Remoting.Messaging;
using StressLevelZero.Interaction;
using UnityEngine.Experimental.PlayerLoop;
using Il2CppSystem.Collections.Generic;

namespace Freeze_Manipulator
{
    public static class BuildInfo
    {
        public const string Name = "Freeze_Manipulator"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Graic"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class Freeze_Manipulator : MelonMod
    {
        Stack<Rigidbody> frozen = new Stack<Rigidbody>();

        float doublePressTimer = 0;
        const float doublePressTimerLenght = 0.5f;

        public override void OnUpdate() {
            if (!Player.FindPlayer()) return;
            UpdateFreeze(Player.rightHand);
            UpdateFreeze(Player.leftHand);
            doublePressTimer = doublePressTimer > 0 ? doublePressTimer -= Time.deltaTime : 0;
        }

        void UpdateFreeze(Hand hand) {
            GameObject go = Player.GetObjectInHand(hand);
            if (go) {
                DevManipulatorGun dmg = go.GetComponentInParent<DevManipulatorGun>();
                if (dmg && hand.controller.GetBButtonDown()) {
                    if (dmg.m_IsGrabbed) { // Freeze
                        dmg.m_GrabbedRigidbody.isKinematic = true;
                        frozen.Push(dmg.m_GrabbedRigidbody);
                        dmg.Blast();
                        dmg.gravityManipulator.ReleaseLockedRigidbody();
                    } else if (doublePressTimer > 0 && frozen.Count > 0) { // Unfreeze
                        frozen.Pop().isKinematic = false;
                        dmg.Blast();
                        doublePressTimer = 0;
                    } else {
                        doublePressTimer = doublePressTimerLenght;
                    }
                }
            }
        }
    }
}
