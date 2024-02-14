import { NextFunction, Request, Response } from 'express'
import { find, getById } from './product.service'

export const list = async (
  req: Request,
  res: Response,
  _next: NextFunction,
) => {
  const { search }: { search?: string } = req.query
  const result = await find(search)
  res.json(result)
}

export const detail = async (req: Request, res: Response, _next: NextFunction) => {
  const { id } = req.params
  const item = await getById(id)
  if (!item) {
    res.status(404)
    res.send('Product not found')
  }
  res.json(item)
}
