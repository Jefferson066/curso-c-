﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S9Exer3.Entities.Enums {
    enum OrderStatus : int {
        PendingPayment = 0,
        Processing = 1,
        Shipped =2,
        Delivered = 3
    }
}
