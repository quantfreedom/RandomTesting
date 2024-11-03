namespace MainChart.ViewModels.AccountOrderTrades.Design;

public class BybitListOrderHistoryDesignModel:BybitListOrderHistoryViewModel
{

    public static BybitListOrderHistoryDesignModel Instance => new BybitListOrderHistoryDesignModel();
    public BybitListOrderHistoryDesignModel()
    {
        Items = [
            new BybitItemOrderHistoryViewModel {
                Symbol = "BTCUSD",
                Side = "Buy",
                OrderType = "Limit",
                Price = 10000,
                Qty = 1,
                AvgPrice = 0,
                LeavesQty = 0,
                LeavesValue = 0,
                CumExecQty = 1,
                CumExecValue = 10000,
                OrderStatus = "Filled",
            },
            new BybitItemOrderHistoryViewModel {
                Symbol = "BTCUSD",
                Side = "Sell",
                OrderType = "Limit",
                Price = 10000,
                Qty = 1,
                AvgPrice = 0,
                LeavesQty = 0,
                LeavesValue = 0,
                CumExecQty = 1,
                CumExecValue = 10000,
                OrderStatus = "Filled",
            },
            new BybitItemOrderHistoryViewModel {
                Symbol = "BTCUSD",
                Side = "Buy",
                OrderType = "Limit",
                Price = 10000,
                Qty = 1,
                AvgPrice = 0,
                LeavesQty = 0,
                LeavesValue = 0,
                CumExecQty = 1,
                CumExecValue = 10000,
                OrderStatus = "Filled",
            },
            new BybitItemOrderHistoryViewModel {
                Symbol = "BTCUSD",
                Side = "Sell",
                OrderType = "Limit",
                Price = 10000,
                Qty = 1,
                AvgPrice = 0,
                LeavesQty = 0,
                LeavesValue = 0,
                CumExecQty = 1,
                CumExecValue = 10000,
                OrderStatus = "Filled",
            },
            ];
    }
}