import { CartItem } from './cart-item.entity'

export const CART: CartItem[] = []

export class CartItemService {
  async add(item: CartItem) {
    const existing = CART.find((element) => element.product === item.product)

    if (existing) {
      existing.quantity += item.quantity
      return existing
    }

    const toAdd = {
      id: `${CART.length}`,
      ...item,
    }

    CART.push(toAdd)

    return toAdd
  }

  async updateQuantity(productId: string, newQuantity: number) {
    const existing = CART.find((element) => element.product === productId)

    if (existing) {
      existing.quantity = newQuantity
      return existing
    }
  }
}

export default new CartItemService()
