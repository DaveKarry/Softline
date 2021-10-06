import React from 'react'
import {Link} from 'react-router-dom'
import {
    ListGroup,
    ListGroupItem,
    Button
} from 'reactstrap'

export const EmployerList = () => {
    return (
        <ListGroup className="mt-4">
            <ListGroupItem className="d-flex">
                <strong>Employer1</strong>
                <div className="ml-auto">
                    <Link className="btn btn-warning mr-1"  to="/edit/1">Edit</Link>
                    <Button color="danger">Delete</Button>
                </div>
            </ListGroupItem>
        </ListGroup>
    )
}
