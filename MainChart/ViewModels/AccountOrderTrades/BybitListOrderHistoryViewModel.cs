using MainChart.ViewModels.Base;

namespace MainChart.ViewModels.AccountOrderTrades;

public class BybitListOrderHistoryViewModel:BaseViewModel
{
    public List<BybitItemOrderHistoryViewModel> Items { get; set; }
}


public class BybitItemOrderHistoryViewModel:BaseViewModel
{
    public string? OrderId { get; set; }
    public string? OrderLinkId { get; set; }
    public string? BlockTradeId { get; set; }
    public string? Symbol { get; set; }
    public decimal Price { get; set; }
    public decimal Qty { get; set; }
    public string? Side { get; set; }
    public string? IsLeverage { get; set; }
    public int PositionIdx { get; set; }
    public string? OrderStatus { get; set; }
    public string? CancelType { get; set; }
    public string? RejectReason { get; set; }
    public decimal AvgPrice { get; set; }
    public decimal LeavesQty { get; set; }
    public decimal LeavesValue { get; set; }
    public decimal CumExecQty { get; set; }
    public decimal CumExecValue { get; set; }
    public decimal CumExecFee { get; set; }
    public string? TimeInForce { get; set; }
    public string? OrderType { get; set; }
    public string? StopOrderType { get; set; }
    public string? OrderIv { get; set; }
    public decimal TriggerPrice { get; set; }
    public decimal TakeProfit { get; set; }
    public decimal StopLoss { get; set; }
    public string? TpTriggerBy { get; set; }
    public string? SlTriggerBy { get; set; }
    public int TriggerDirection { get; set; }
    public string? TriggerBy { get; set; }
    public string? LastPriceOnCreated { get; set; }
    public bool ReduceOnly { get; set; }
    public bool CloseOnTrigger { get; set; }
    public string? SmpType { get; set; }
    public int SmpGroup { get; set; }
    public string? SmpOrderId { get; set; }
    public string? TpslMode { get; set; }
    public string? TpLimitPrice { get; set; }
    public string? SlLimitPrice { get; set; }
    public string? PlaceType { get; set; }
    public long CreatedTime { get; set; }
    public long UpdatedTime { get; set; }

}