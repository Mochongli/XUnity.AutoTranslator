﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
   public class Object
   {
      public string name
      {
         get => throw new NotImplementedException();
         set => throw new NotImplementedException();
      }

      public HideFlags hideFlags
      {
         get => throw new NotImplementedException();
         set => throw new NotImplementedException();
      }

      public static void Destroy( Object obj, float t ) => throw new NotImplementedException();

      public static void Destroy( Object obj ) => throw new NotImplementedException();

      public static void DestroyImmediate( Object obj, bool allowDestroyingAssets ) => throw new NotImplementedException();

      public static void DestroyImmediate( Object obj ) => throw new NotImplementedException();

      public static Object[] FindObjectsOfType( Type type ) => throw new NotImplementedException();

      public static void DontDestroyOnLoad( Object target ) => throw new NotImplementedException();

      public static void DestroyObject( Object obj, float t ) => throw new NotImplementedException();

      public static void DestroyObject( Object obj ) => throw new NotImplementedException();

      public static Object[] FindSceneObjectsOfType( Type type ) => throw new NotImplementedException();

      public static Object[] FindObjectsOfTypeIncludingAssets( Type type ) => throw new NotImplementedException();

      public static Object[] FindObjectsOfTypeAll( Type type ) => throw new NotImplementedException();

      public override string ToString() => throw new NotImplementedException();

      public int GetInstanceID() => throw new NotImplementedException();

      public override int GetHashCode() => throw new NotImplementedException();

      public override bool Equals( object other ) => throw new NotImplementedException();

      public static implicit operator bool( Object exists ) => throw new NotImplementedException();

      private static bool CompareBaseObjects( Object lhs, Object rhs ) => throw new NotImplementedException();

      private static bool IsNativeObjectAlive( Object o ) => throw new NotImplementedException();

      private IntPtr GetCachedPtr() => throw new NotImplementedException();

      public static Object Instantiate( Object original, Vector3 position, Quaternion rotation ) => throw new NotImplementedException();

      public static Object Instantiate( Object original, Vector3 position, Quaternion rotation, Transform parent ) => throw new NotImplementedException();

      public static Object Instantiate( Object original ) => throw new NotImplementedException();

      public static Object Instantiate( Object original, Transform parent ) => throw new NotImplementedException();

      public static Object Instantiate( Object original, Transform parent, bool instantiateInWorldSpace ) => throw new NotImplementedException();

      public static T Instantiate<T>( T original ) where T : Object => throw new NotImplementedException();

      public static T Instantiate<T>( T original, Vector3 position, Quaternion rotation ) where T : Object => throw new NotImplementedException();

      public static T Instantiate<T>( T original, Vector3 position, Quaternion rotation, Transform parent ) where T : Object => throw new NotImplementedException();

      public static T Instantiate<T>( T original, Transform parent ) where T : Object => throw new NotImplementedException();

      public static T Instantiate<T>( T original, Transform parent, bool worldPositionStays ) where T : Object => throw new NotImplementedException();

      public static T[] FindObjectsOfType<T>() where T : Object => throw new NotImplementedException();

      public static T FindObjectOfType<T>() where T : Object => throw new NotImplementedException();

      private static void CheckNullArgument( object arg, string message ) => throw new NotImplementedException();

      public static Object FindObjectOfType( Type type ) => throw new NotImplementedException();

      public static bool operator ==( Object x, Object y ) => throw new NotImplementedException();

      public static bool operator !=( Object x, Object y ) => throw new NotImplementedException();
   }
}
