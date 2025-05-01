
namespace DO;


[Serializable]
public class Dal_idNotFound : Exception
{
    public Dal_idNotFound(string message) : base(message)
    {

    }
}

[Serializable]
public class Dal_idIsExist : Exception
{
    public Dal_idIsExist(string message) : base(message)
    {

    }
}

[Serializable]
public class Dal_objectNotFound : Exception
{
    public Dal_objectNotFound(string message) : base(message)
    {

    }
}

[Serializable]
public class Dal_numOfManuIsNotValid : Exception
{
    public Dal_numOfManuIsNotValid(string message) //: base(message)
    {
        throw new Exception("wrong! please choose againnnnn");
    }
}


