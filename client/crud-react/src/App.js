import './App.css';
import {Home} from "./components/Home";
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom'
import AddEmployer from "./components/AddEmployer";
import {EditEmployer} from "./components/EditEmployer";

import 'bootstrap/dist/css/bootstrap.min.css'

function App() {
  return (
    <div className="App" style={{ maxWidth: "80rem", margin:"4rem auto"}}>
      <h1>App</h1>
      <Router>
        <Switch>
          <Route path="/add" component={AddEmployer}/>
          <Route path="/edit/{id}" component={EditEmployer}/>
          <Route path="/" component={Home}/>
          
          </Switch>
      </Router>
      
    </div>
  );
}

export default App;
