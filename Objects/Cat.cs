﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Mu20
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Cat.
    /// </summary>
    //  *** Start programmer edit section *** (Cat CustomAttributes)

    //  *** End programmer edit section *** (Cat CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("CatE", new string[0])]
    [View("CatL", new string[0])]
    public class Cat : ICSSoft.STORMNET.DataObject
    {
        
        //  *** Start programmer edit section *** (Cat CustomMembers)

        //  *** End programmer edit section *** (Cat CustomMembers)

        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CatE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CatE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CatE", typeof(IIS.Mu20.Cat));
                }
            }
            
            /// <summary>
            /// "CatL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CatL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CatL", typeof(IIS.Mu20.Cat));
                }
            }
        }
    }
}
