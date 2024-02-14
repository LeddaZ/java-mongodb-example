import { NextFunction, Request, Response } from 'express'
import PRODUCTS from '../../../products.json'

export const list = async (
  req: Request,
  res: Response,
  _next: NextFunction,
) => {
  const { search }: { search?: string } = req.query
  let results = PRODUCTS

  if (search) {
    results = PRODUCTS.filter((item) => {
      return item.name.toLowerCase().includes(search.toLowerCase())
    })
  }

  res.json(results)
}

export const detail = (req: Request, res: Response, _next: NextFunction) => {
  const { id } = req.params
  const item = PRODUCTS.find((item) => {
    return item.id === id
  })
  if (!item) {
    res.status(404)
    res.send('Product not found')
  }
}
