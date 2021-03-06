using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NakedObjects;

namespace Demo.Dom.CoffeeShop
{
    public partial class Order
    {
    
        #region Primitive Properties
        #region OrderNum (Int32)
    [MemberOrder(100)]
        public virtual int  OrderNum {get; set;}

        #endregion
        #region DrinkSku (String)
    [MemberOrder(110), StringLength(8)]
        public virtual string  DrinkSku {get; set;}

        #endregion
        #region Price (Decimal)
    [MemberOrder(120)]
        public virtual decimal  Price {get; set;}

        #endregion
        #region CustomerName (String)
    [MemberOrder(130)]
        public virtual string  CustomerName {get; set;}

        #endregion
        #region CustomerState (Byte)
    [MemberOrder(140)]
        public virtual byte  CustomerState {get; set;}

        #endregion
        #region BaristaState (Byte)
    [MemberOrder(150)]
        public virtual byte  BaristaState {get; set;}

        #endregion
        #region PlacedOn (DateTime)
    [MemberOrder(160), Mask("d")]
        public virtual System.DateTime  PlacedOn {get; set;}

        #endregion

        #endregion
        #region Navigation Properties
        #region Drink (Product)
    		
    [MemberOrder(170)]
    	public virtual Product Drink {get; set;}

        #endregion
        #region Additions (Collection of OrderAddition)
    		
    	    private ICollection<OrderAddition> _additions = new List<OrderAddition>();
    		
    		[MemberOrder(180), Disabled]
        public virtual ICollection<OrderAddition> Additions
        {
            get
            {
                return _additions;
            }
    		set
    		{
    		    _additions = value;
    		}
        }

        #endregion

        #endregion
    }
}
