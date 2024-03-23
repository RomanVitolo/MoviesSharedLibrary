﻿namespace SharedLibrary.Interfaces.Entities;

public interface ICinemaDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}