﻿namespace ComexAPI.Data.Dtos;

public class ReadClienteDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDto ReadEnderecoDto { get; set; }
}
