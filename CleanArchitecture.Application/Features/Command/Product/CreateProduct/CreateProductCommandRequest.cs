﻿using MediatR;

namespace CleanArchitecture.Application.Features.Command.Product.CreateProduct;

public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
{
    public string Name { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    
    
}
