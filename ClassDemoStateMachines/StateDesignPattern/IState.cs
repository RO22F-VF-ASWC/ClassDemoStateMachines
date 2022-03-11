namespace ClassDemoStateMachines.StateDesignPattern
{
    public interface IState<Tin, Tout>
    {
        IState<Tin, Tout> NextStateFunction(Tin input);
        Tout OutputFunction(Tin input);
    }
}
