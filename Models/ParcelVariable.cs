namespace Parcel.Models
{
  public class ParcelVariable
  {
    private string _recipient;
    private int _weight;
    private int _dimX;
    private int _dimY;
    private int _dimZ;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetDimX()
    {
      return _dimX;
    }

    public void SetDimX(int newDimX)
    {
      _dimX = newDimX;
    }

    public int GetDimY()
    {
      return _dimY;
    }

    public void SetDimY(int newDimY)
    {
      _dimY = newDimY;
    }

    public int GetDimZ()
    {
      return _dimZ;
    }

    public void SetDimZ(int newDimZ)
    {
      _dimZ = newDimZ;
    }

    public int GetVolume()
    {
        return _dimX*_dimY*_dimZ;
    }
    public int GetCostToShip()
    {
        int costs = _weight / 10 + _dimX*_dimY*_dimZ / 10;
        return costs;
    }
  }
}
