import PRODUCTS from '../../../products.json'

export async function find(search?: string) {
  let results = PRODUCTS

  if (search) {
    results = PRODUCTS.filter((item) => {
      return item.name.toLowerCase().includes(search.toLowerCase())
    })
  }

  return results
}

export async function getById(id: string) {
  return PRODUCTS.find((item) => {
    return item.id === id
  })
}
