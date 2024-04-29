using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    #region What You Can Write Inside Namespace ?

    //  1. Class     [Support Inheritance]
    //  2. Struct    [Not Support Inheritance] [stand for structure]
    //  3. Interface
    //  4. Enum 

    #endregion

    #region Access Modifier Allowed Inside Namespace ?

    //  1. Internal [Default Access Modifier]
    //  2. Public
    
    #endregion

    public class TypeA
    {

        #region What You Can Write Inside The Struct Or Class ?

        // 1. Attributes[Fields] → Member Variable  
        // 2. Functions[Constructor, Getter Setter, Method]
        // 3. Properties[Full Property, Automatic Property, Indexer]
        // 4. Events

        #endregion

        #region Access Modifier Allowed Inside Struct?

        // 1. Private [Default]
        // 2. Internal
        // 3. Public

        #endregion

        #region Access Modifier Allowed Inside Class?
        // 1. Private[Default]
        // 2. Private Protected 
        // 3. Protected 
        // 4. Internal
        // 5. Protected Internal 
        // 6. Public  
        #endregion

        //    private int x;  // Accessable within it's Scope Only
        //    internal int y; // Accessable within it's Scope and project
        //    public int z;   // Accessable within it's Scope and project and external projects

        #region What You Can Write Inside The Interface ?

        // 1. Signature For Property 
        // 2. Signature For Method 
        // 3. Default Implemented Method 

        #endregion
    }
}
