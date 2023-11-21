import React from 'react'

export const Error = ({mensaje}) => {
  return (
    <div>
        <p className='fw-bold text-danger'>{mensaje}</p>
    </div>
  )
}
