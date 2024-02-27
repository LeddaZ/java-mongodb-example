import { NextFunction, Request, Response } from 'express'
import productService from '../product/product.service'
import { CartItem } from './cart-item.entity'
import cartItemService from './cart-item.service'

export const cartItemList = async (
  req: Request,
  res: Response,
  _next: NextFunction,
) => {}

export const add = async (req: Request, res: Response, _next: NextFunction) => {
  const { productId, quantity } = req.body
  console.log(productId, quantity)

  const product = await productService.getById(productId)
  if (!product) {
    res.send(404)
    return
  }

  const newItem: CartItem = {
    product: productId,
    quantity,
  }

  const saved = await cartItemService.add(newItem)

  res.json(saved)
}

export const updateQuantity = async (
  req: Request,
  res: Response,
  _next: NextFunction,
) => {}

export const remove = async (
  req: Request,
  res: Response,
  _next: NextFunction,
) => {}
