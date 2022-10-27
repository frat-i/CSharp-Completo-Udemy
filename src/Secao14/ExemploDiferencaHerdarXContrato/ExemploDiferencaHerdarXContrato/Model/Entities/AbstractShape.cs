using ExemploDiferencaHerdarXContrato.Model.Enums;

namespace ExemploDiferencaHerdarXContrato.Model.Entities;
internal abstract class AbstractShape : IShape
{
    public Color Color { get; set; }

    public abstract double Area();
}
