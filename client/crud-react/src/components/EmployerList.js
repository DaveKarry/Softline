import React, { Component } from 'react'
import {Link} from 'react-router-dom'
import {
    ListGroup,
    ListGroupItem,
    Button
} from 'reactstrap'
import axios from 'axios'

class EmployerList extends Component{
    constructor(props){
        super(props)
        this.state ={
            employers: []
        }
    }

    componentDidMount(){
        axios.get('https://localhost:5001/api/employers')
        .then(response => {
            this.setState({
                employers: response.data
            })
            console.log(response.data)
        })
    }
    render(){
        const {employers} = this.state
        console.log(employers)
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
}

export default EmployerList