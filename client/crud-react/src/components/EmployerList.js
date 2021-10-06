import React, { Component } from 'react'
import {Link} from 'react-router-dom'
import {
    ListGroup,
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
        axios.get('https://localhost:5001/api/employers', )
        .then(response => {
            this.setState({
                employers: response.data
            })
            console.log(response.maternityLeave)
        })
    }
    render(){
        const {employers} = this.state
        return (
            <ListGroup className="mt-4">
                <table>
                    <tr>
                        <th>name</th>
                        <th>surname</th>
                        <th>midname</th>
                        <th>position</th>
                        <th>note</th>
                        <th>maternityLeave</th>
                        <th>birthDate</th>
                        <th>action</th>
                    </tr>

                    {employers.map(employer =>
                        <tr key={employer.id}>
                            <td>{employer.name}</td>
                            <td>{employer.surname}</td>
                            <td>{employer.midname}</td>
                            <td>{employer.position}</td>
                            <td>{employer.note}</td>
                            <td>{String(employer.maternityLeave)}</td>
                            <td>{employer.birthDate}</td>
                            <td>
                                <div className="ml-auto">

                                    <Link className="btn btn-warning mr-1" to="/edit/1">Edit</Link>
                                    <Button color="danger">Delete</Button>

                                </div>
                            </td>
                        </tr>
                    )}
                </table>
            </ListGroup>
        )
    }
}

export default EmployerList