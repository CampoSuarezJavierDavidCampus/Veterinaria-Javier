using Core.Interfaces;

namespace Api.Helpers;

public class Params{
    private int _pageSize = 5;
    private const int MaxPageSize = 50;
    private int _pageIndex = 1;    
    public int PageSize{
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }

    public int PageIndex{
        get => _pageIndex;
        set => _pageIndex = (value <= 0) ? 1 : value;
    }
    
}

public class Param:Params, IParam{
    public Param(Params param){
        PageSize = param.PageSize;
        PageIndex = param.PageIndex;        
    }
}