using DO;

namespace BO;


[Serializable]
public class Bl_idNotFound : Exception
{
    public Bl_idNotFound(string message) : base(message)
    { }
    public Bl_idNotFound(string message, Dal_idNotFound innerException)
            : base(message, innerException) { }
}

[Serializable]
public class Bl_idIsExist : Exception
{
    public Bl_idIsExist(string message) : base(message)
    { }
    public Bl_idIsExist(string message, Dal_idIsExist innerException)
        : base(message, innerException) { }
}

[Serializable]
public class Bl_objectNotFound : Exception
{
    public Bl_objectNotFound(string message) : base(message)
    { }
    public Bl_objectNotFound(string message, Dal_objectNotFound innerException)
        : base(message, innerException) { }
}

[Serializable]
public class Bl_InValidInput : Exception
{
    public Bl_InValidInput(string message) : base(message)
    { }

    public Bl_InValidInput(string message, Exception innerException)
        : base(message, innerException) { }
}

[Serializable]
public class Bl_OutOfStock : Exception
{
    public Bl_OutOfStock(string message) : base(message)
    { }

    public Bl_OutOfStock(string message, Exception innerException)
        : base(message, innerException) { }
}